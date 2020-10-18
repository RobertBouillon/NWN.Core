using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;

namespace Generator
{
  public class NWXLibrary : ILibrary
  {
    public void Preprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Postprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Setup(Driver driver)
    {
      Environment.CurrentDirectory = @"../../../../../unified";

      DriverOptions options = driver.Options;
      options.GeneratorKind = GeneratorKind.CSharp;
      options.GenerateSingleCSharpFile = false;
      options.GenerateClassTemplates = true;
      options.GenerateFunctionTemplates = true;
      options.OutputDir = @"../NWN.Core/NWN.Core/src/NWN/LowLevel";
      options.DryRun = false;
      options.Verbose = true;

      Module module = options.AddModule("NWNXLib");
      module.OutputNamespace = "NWN.LowLevel";

      module.IncludeDirs.Add(@"./NWNXLib/API");
      module.IncludeDirs.Add(@"./NWNXLib/API/API");
      module.IncludeDirs.Add(@"./NWNXLib/API/Constants");

      List<string> files = Directory.GetFiles(@"./NWNXLib/API/API").Select(path => Path.GetFileName(path)).ToList();
      files.Add("nwn_api.hpp");
      files.AddRange(Directory.GetFiles(@"./NWNXLib/API/Constants").Select(path => Path.GetFileName(path)));

      foreach (string file in files)
      {
        if (file == "CExoResFile.hpp" || file == "CNetLayerWindow.hpp" || file == "DestroyHelper.hpp" || file == "StartupConfig.hpp" || file == "StorageShard.hpp" || file == "StorageShardAllocParams.hpp")
        {
          continue;
        }

        module.Headers.Add(file);
      }
    }

    public void SetupPasses(Driver driver)
    {
      driver.Context.TranslationUnitPasses.RenameDeclsUpperCase(RenameTargets.Any);
      driver.Context.TranslationUnitPasses.AddPass(new FunctionToInstanceMethodPass());
    }
  }
}
