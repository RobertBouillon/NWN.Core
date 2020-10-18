#define _LIBCPP_DISABLE_VISIBILITY_ANNOTATIONS
#define _LIBCPP_HIDE_FROM_ABI

#include <ALL_CLASSES.hpp>
#include <AurList.hpp>
#include <BIFFFILE_HEADER.hpp>
#include <BIFFFILE_VARRESENTRY_E1.hpp>
#include <BIFFFILE_VARRESENTRY_V1.hpp>
#include <C2DA.hpp>
#include <CachedRulesetEntry.hpp>
#include <CAppManager.hpp>
#include <CAurObjectVisualTransformData.hpp>
#include <CAutoSave.hpp>
#include <CBaseExoApp.hpp>
#include <CCallbackHandlerBase.hpp>
#include <CCombatInformation.hpp>
#include <CCombatInformationNode.hpp>
#include <CEffectIconObject.hpp>
#include <CEncounterListEntry.hpp>
#include <CEncounterSpawnPoint.hpp>
#include <CERFFile.hpp>
#include <CERFKey.hpp>
#include <CERFRes.hpp>
#include <CERFString.hpp>
#include <CExoAliasList.hpp>
#include <CExoApp.hpp>
#include <CExoArrayList.hpp>
#include <CExoBase.hpp>
#include <CExoBaseInternal.hpp>
#include <CExoCriticalSection.hpp>
#include <CExoDebug.hpp>
#include <CExoDebugInternal.hpp>
#include <CExoEncapsulatedFile.hpp>
#include <CExoEncrypt.hpp>
#include <CExoFile.hpp>
#include <CExoIdentity.hpp>
#include <CExoIni.hpp>
#include <CExoIniInternal.hpp>
#include <CExoInput.hpp>
#include <CExoInputClass.hpp>
#include <CExoInputEvent.hpp>
#include <CExoInputEventDesc.hpp>
#include <CExoKeyTable.hpp>
#include <CExoLinkedList.hpp>
#include <CExoLinkedListInternal.hpp>
#include <CExoLinkedListNode.hpp>
#include <CExoLocString.hpp>
#include <CExoLocStringInternal.hpp>
#include <CExoPackedFile.hpp>
#include <CExoRand.hpp>
#include <CExoRandInternal.hpp>
#include <CExoResMan.hpp>
#include <CExoResourceImageFile.hpp>
#include <CExoString.hpp>
#include <CExoStringList.hpp>
#include <CExoTimers.hpp>
#include <CExoTimersInternal.hpp>
#include <CExtendedServerInfo.hpp>
#include <CFactionManager.hpp>
#include <CFeatUseListEntry.hpp>
#include <CFileInfo.hpp>
#include <CGameEffect.hpp>
#include <CGameEffectApplierRemover.hpp>
#include <CGameObject.hpp>
#include <CGameObjectArray.hpp>
#include <CGameObjectArrayNode.hpp>
#include <CItemPropertyApplierRemover.hpp>
#include <CItemRepository.hpp>
#include <CJoiningRestrictions.hpp>
#include <CKeyTableEntry.hpp>
#include <CKeyTableInfo.hpp>
#include <CLastUpdateObject.hpp>
#include <CLastUpdatePartyObject.hpp>
#include <CLoopingVisualEffect.hpp>
#include <CMessagePlayer.hpp>
#include <CMessageSysAdmin.hpp>
#include <CNetLayer.hpp>
#include <CNetLayerPlayerCDKeyInfo.hpp>
#include <CNetLayerPlayerInfo.hpp>
#include <CNetLayerSessionInfo.hpp>
#include <CNWActionNode.hpp>
#include <CNWAmbientSound.hpp>
#include <CNWAnimBase.hpp>
#include <CNWArea.hpp>
#include <CNWBaseItem.hpp>
#include <CNWBaseItemArray.hpp>
#include <CNWCCMessageData.hpp>
#include <CNWClass.hpp>
#include <CNWClass_Feat.hpp>
#include <CNWClass_Skill.hpp>
#include <CNWCreatureStatsUpdate.hpp>
#include <CNWDomain.hpp>
#include <CNWDoorSurfaceMesh.hpp>
#include <CNWFeat.hpp>
#include <CNWGridSearchPath.hpp>
#include <CNWItem.hpp>
#include <CNWItemProperty.hpp>
#include <CNWLevelStats.hpp>
#include <CNWMessage.hpp>
#include <CNWNameGen.hpp>
#include <CNWPlaceableSurfaceMesh.hpp>
#include <CNWPlaceMeshManager.hpp>
#include <CNWRace.hpp>
#include <CNWRules.hpp>
#include <CNWSAmbientSound.hpp>
#include <CNWSAnimBase.hpp>
#include <CNWSArea.hpp>
#include <CNWSAreaGridPoint.hpp>
#include <CNWSAreaGridSuccessors.hpp>
#include <CNWSAreaGridTransTableEntry.hpp>
#include <CNWSAreaInterTileSuccessors.hpp>
#include <CNWSAreaOfEffectObject.hpp>
#include <CNWSBarter.hpp>
#include <CNWSClient.hpp>
#include <CNWSCombatAttackData.hpp>
#include <CNWSCombatRound.hpp>
#include <CNWSCombatRoundAction.hpp>
#include <CNWSCreature.hpp>
#include <CNWSCreatureAppearanceInfo.hpp>
#include <CNWSCreatureStats.hpp>
#include <CNWSCreatureStats_ClassInfo.hpp>
#include <CNWSCreRestorePolymorphData.hpp>
#include <CNWSDialog.hpp>
#include <CNWSDialogEntry.hpp>
#include <CNWSDialogLinkEntry.hpp>
#include <CNWSDialogLinkReply.hpp>
#include <CNWSDialogPlayer.hpp>
#include <CNWSDialogReply.hpp>
#include <CNWSDialogSpeaker.hpp>
#include <CNWSDoor.hpp>
#include <CNWSEffectListHandler.hpp>
#include <CNWSEncounter.hpp>
#include <CNWSExpression.hpp>
#include <CNWSExpressionList.hpp>
#include <CNWSExpressionNode.hpp>
#include <CNWSFaction.hpp>
#include <CNWSForcedAction.hpp>
#include <CNWSInventory.hpp>
#include <CNWSInvitationDetails.hpp>
#include <CNWSItem.hpp>
#include <CNWSJournal.hpp>
#include <CNWSkill.hpp>
#include <CNWSMessage.hpp>
#include <CNWSModule.hpp>
#include <CNWSObject.hpp>
#include <CNWSObjectActionNode.hpp>
#include <CNWSObjectEventHandler.hpp>
#include <CNWSpell.hpp>
#include <CNWSpellArray.hpp>
#include <CNWSPersonalReputation.hpp>
#include <CNWSPlaceable.hpp>
#include <CNWSPlayer.hpp>
#include <CNWSPlayerCharSheetGUI.hpp>
#include <CNWSPlayerContainerGUI.hpp>
#include <CNWSPlayerInventoryGUI.hpp>
#include <CNWSPlayerJournalQuest.hpp>
#include <CNWSPlayerJournalQuestUpdates.hpp>
#include <CNWSPlayerLastUpdateObject.hpp>
#include <CNWSPlayerLUOAppearanceInfo.hpp>
#include <CNWSPlayerLUOInventory.hpp>
#include <CNWSPlayerLUOInventoryItem.hpp>
#include <CNWSPlayerLUOQuickbarItemButton.hpp>
#include <CNWSPlayerLUOSortedObjectList.hpp>
#include <CNWSPlayerStoreGUI.hpp>
#include <CNWSPlayerTURD.hpp>
#include <CNWSPortal.hpp>
#include <CNWSPVPEntry.hpp>
#include <CNWSQuickbarButton.hpp>
#include <CNWSRules.hpp>
#include <CNWSScriptVar.hpp>
#include <CNWSScriptVarTable.hpp>
#include <CNWSSound.hpp>
#include <CNWSSoundObject.hpp>
#include <CNWSSpellScriptData.hpp>
#include <CNWSStats_Spell.hpp>
#include <CNWSStats_SpellLikeAbility.hpp>
#include <CNWSStore.hpp>
#include <CNWSSysAdmin.hpp>
#include <CNWSTagNode.hpp>
#include <CNWSTile.hpp>
#include <CNWSTileSet.hpp>
#include <CNWSTransition.hpp>
#include <CNWSTrigger.hpp>
#include <CNWSUUID.hpp>
#include <CNWSWaypoint.hpp>
#include <CNWSync.hpp>
#include <CNWTile.hpp>
#include <CNWTileData.hpp>
#include <CNWTilePathNode.hpp>
#include <CNWTileSet.hpp>
#include <CNWTileSetManager.hpp>
#include <CNWTileSurfaceMesh.hpp>
#include <CNWTileSurfaceMeshAABBNode.hpp>
#include <CNWTileSurfaceMeshHashTableEntry.hpp>
#include <CNWTileSurfaceMeshLocalInfo.hpp>
#include <CNWTileSurfaceMeshNodeFace.hpp>
#include <CNWTileSurfaceMeshNodeVertex.hpp>
#include <CNWTileSurfaceMeshSortSuccessors.hpp>
#include <CNWVirtualMachineCommands.hpp>
#include <CNWVisibilityNode.hpp>
#include <CObjectLookupTable.hpp>
#include <CObjectTableManager.hpp>
#include <CPathfindInfoIntraTileSuccessors.hpp>
#include <CPathfindInformation.hpp>
#include <CPersistantWorldOptions.hpp>
#include <CPlayOptions.hpp>
#include <CRes.hpp>
#include <CRes2DA.hpp>
#include <CResARE.hpp>
#include <CResDWK.hpp>
#include <CResetOption.hpp>
#include <CResGenericFileHeader.hpp>
#include <CResGFF.hpp>
#include <CResGFFField.hpp>
#include <CResGFFFileHeader.hpp>
#include <CResGFFLabel.hpp>
#include <CResGFFStruct.hpp>
#include <CResHelper.hpp>
#include <CResIFO.hpp>
#include <CResList.hpp>
#include <CResLTR.hpp>
#include <CResMDL.hpp>
#include <CResNCS.hpp>
#include <CResNDB.hpp>
#include <CResNSS.hpp>
#include <CResPWK.hpp>
#include <CResRef.hpp>
#include <CResSET.hpp>
#include <CResStruct.hpp>
#include <CResStructHeader.hpp>
#include <CResStructInternal.hpp>
#include <CResStructLookUp.hpp>
#include <CResTLK.hpp>
#include <CResWOK.hpp>
#include <CScriptCompiler.hpp>
#include <CScriptCompilerIdentifierHashTableEntry.hpp>
#include <CScriptCompilerIdListEntry.hpp>
#include <CScriptCompilerIncludeFileStackEntry.hpp>
#include <CScriptCompilerKeyWordEntry.hpp>
#include <CScriptCompilerStackEntry.hpp>
#include <CScriptCompilerStructureEntry.hpp>
#include <CScriptCompilerStructureFieldEntry.hpp>
#include <CScriptCompilerSymbolTableEntry.hpp>
#include <CScriptCompilerVarStackEntry.hpp>
#include <CScriptEvent.hpp>
#include <CScriptLocation.hpp>
#include <CScriptLog.hpp>
#include <CScriptParseTreeNode.hpp>
#include <CScriptParseTreeNodeBlock.hpp>
#include <CScriptSourceFile.hpp>
#include <CScriptTalent.hpp>
#include <CServerAIBodyBagInfo.hpp>
#include <CServerAIEventNode.hpp>
#include <CServerAIList.hpp>
#include <CServerAIMaster.hpp>
#include <CServerExoApp.hpp>
#include <CServerExoAppInternal.hpp>
#include <CServerInfo.hpp>
#include <CServerNetOptions.hpp>
#include <CServerOptionLookup.hpp>
#include <CSpell_Add.hpp>
#include <CSpell_Delete.hpp>
#include <CStoreCustomer.hpp>
#include <CStringFieldIDType.hpp>
#include <CTlkFile.hpp>
#include <CTlkResFile.hpp>
#include <CTlkTable.hpp>
#include <CTlkTableToken.hpp>
#include <CTlkTableTokenCustom.hpp>
#include <CTwoDimArrays.hpp>
#include <CVirtualMachine.hpp>
#include <CVirtualMachineCmdImplementer.hpp>
#include <CVirtualMachineDebuggerInstance.hpp>
#include <CVirtualMachineDebuggingContext.hpp>
#include <CVirtualMachineDebugLoader.hpp>
#include <CVirtualMachineFile.hpp>
#include <CVirtualMachineScript.hpp>
#include <CVirtualMachineStack.hpp>
#include <CWalkHitInfo.hpp>
#include <CWorldJournalEntry.hpp>
#include <CWorldTimer.hpp>
#include <ENCAPSULATED_HEADER.hpp>
#include <ENCAPSULATED_KEYLISTENTRY.hpp>
#include <ENCAPSULATED_RESLISTENTRY.hpp>
#include <ENCAPSULATED_RESLISTENTRY_E1.hpp>
#include <EXO2DAHEADER.hpp>
#include <EXOLOCSTRING.hpp>
#include <EXOLTRHEADER.hpp>
#include <IntendedConnectionData.hpp>
#include <KeyFileData.hpp>
#include <KEYFILE_HEADER.hpp>
#include <KEYFILE_KEYENTRY.hpp>
#include <KEYFILE_RESFILENAME.hpp>
#include <KXPacket.hpp>
#include <MaterialShaderParam.hpp>
#include <NWAREAEXPANSION.hpp>
#include <NWAREAHEADER.hpp>
#include <NWERFHEADER.hpp>
#include <NWMODULECUTSCENE.hpp>
#include <NWMODULEENTRYINFO.hpp>
#include <NWMODULEEXPANSION.hpp>
#include <NWMODULEHEADER.hpp>
#include <NWPlayerCharacterListClass_st.hpp>
#include <NWPlayerCharacterList_st.hpp>
#include <NWPLAYERLISTITEM.hpp>
#include <NWSyncAdvertisement.hpp>
#include <NWSyncAdvertisementManifest.hpp>
#include <ObjectVisualTransformData.hpp>
#include <out_of_space_error.hpp>
#include <PlatformIntrinsicsProvider.hpp>
#include <Provider.hpp>
#include <RESID.hpp>
#include <RES_FIXED_HEADER.hpp>
#include <ScriptParam.hpp>
#include <SETEntry.hpp>
#include <SETSection.hpp>
#include <SJournalEntry.hpp>
#include <SNWItemFlags.hpp>
#include <SqlQueryEngineStructure.hpp>
#include <SSubNetProfile.hpp>
#include <StackElement.hpp>
#include <STR_RES.hpp>
#include <STR_RES_HEADER.hpp>
#include <STR_RES_HEADER_OLD.hpp>
#include <TextureReplaceInfo.hpp>
#include <TLK_FILE_HEADER.hpp>
#include <Vector.hpp>
#include <Vector2.hpp>
#include <nwn_api.hpp>
#include <Animation.hpp>
#include <Base.hpp>
#include <ClassType.hpp>
#include <Effect.hpp>
#include <Events.hpp>
#include <Feat.hpp>
#include <Item.hpp>
#include <Messages.hpp>
#include <Misc.hpp>
#include <MiscRules.hpp>
#include <RacialType.hpp>
#include <Skill.hpp>
#include <VirtualMachine.hpp>
#include <new>

template AurList<CStringFieldIDType>::AurList(int);
template AurList<CStringFieldIDType>::AurList(AurList<CStringFieldIDType>&);
template AurList<CStringFieldIDType>::~AurList();
void (AurList<CStringFieldIDType>::*_0)(int) = &AurList<CStringFieldIDType>::allocate;
void (AurList<CStringFieldIDType>::*_1)(int) = &AurList<CStringFieldIDType>::SetSize;
void (AurList<CStringFieldIDType>::*_2)() = &AurList<CStringFieldIDType>::Pack;
void (AurList<CStringFieldIDType>::*_3)(CStringFieldIDType) = &AurList<CStringFieldIDType>::Add;
void (AurList<CStringFieldIDType>::*_4)(CStringFieldIDType) = &AurList<CStringFieldIDType>::AddUnique;
bool (AurList<CStringFieldIDType>::*_5)(CStringFieldIDType) = &AurList<CStringFieldIDType>::Contains;
void (AurList<CStringFieldIDType>::*_6)(CStringFieldIDType, int) = &AurList<CStringFieldIDType>::Insert;
int (AurList<CStringFieldIDType>::*_7)(CStringFieldIDType) = &AurList<CStringFieldIDType>::IndexOf;
void (AurList<CStringFieldIDType>::*_8)(CStringFieldIDType) = &AurList<CStringFieldIDType>::Remove;
void (AurList<CStringFieldIDType>::*_9)(int) = &AurList<CStringFieldIDType>::DelIndex;
AurList<CStringFieldIDType>& (AurList<CStringFieldIDType>::*_10)(AurList<CStringFieldIDType>&) = &AurList<CStringFieldIDType>::operator=;
template AurList<CResStructLookUp*>::AurList(int);
template AurList<CResStructLookUp*>::AurList(AurList<CResStructLookUp*>&);
template AurList<CResStructLookUp*>::~AurList();
void (AurList<CResStructLookUp*>::*_11)(int) = &AurList<CResStructLookUp*>::allocate;
void (AurList<CResStructLookUp*>::*_12)(int) = &AurList<CResStructLookUp*>::SetSize;
void (AurList<CResStructLookUp*>::*_13)() = &AurList<CResStructLookUp*>::Pack;
void (AurList<CResStructLookUp*>::*_14)(CResStructLookUp*) = &AurList<CResStructLookUp*>::Add;
void (AurList<CResStructLookUp*>::*_15)(CResStructLookUp*) = &AurList<CResStructLookUp*>::AddUnique;
bool (AurList<CResStructLookUp*>::*_16)(CResStructLookUp*) = &AurList<CResStructLookUp*>::Contains;
void (AurList<CResStructLookUp*>::*_17)(CResStructLookUp*, int) = &AurList<CResStructLookUp*>::Insert;
int (AurList<CResStructLookUp*>::*_18)(CResStructLookUp*) = &AurList<CResStructLookUp*>::IndexOf;
void (AurList<CResStructLookUp*>::*_19)(CResStructLookUp*) = &AurList<CResStructLookUp*>::Remove;
void (AurList<CResStructLookUp*>::*_20)(int) = &AurList<CResStructLookUp*>::DelIndex;
AurList<CResStructLookUp*>& (AurList<CResStructLookUp*>::*_21)(AurList<CResStructLookUp*>&) = &AurList<CResStructLookUp*>::operator=;
template AurList<CStringFieldIDType*>::AurList(int);
template AurList<CStringFieldIDType*>::AurList(AurList<CStringFieldIDType*>&);
template AurList<CStringFieldIDType*>::~AurList();
void (AurList<CStringFieldIDType*>::*_22)(int) = &AurList<CStringFieldIDType*>::allocate;
void (AurList<CStringFieldIDType*>::*_23)(int) = &AurList<CStringFieldIDType*>::SetSize;
void (AurList<CStringFieldIDType*>::*_24)() = &AurList<CStringFieldIDType*>::Pack;
void (AurList<CStringFieldIDType*>::*_25)(CStringFieldIDType*) = &AurList<CStringFieldIDType*>::Add;
void (AurList<CStringFieldIDType*>::*_26)(CStringFieldIDType*) = &AurList<CStringFieldIDType*>::AddUnique;
bool (AurList<CStringFieldIDType*>::*_27)(CStringFieldIDType*) = &AurList<CStringFieldIDType*>::Contains;
void (AurList<CStringFieldIDType*>::*_28)(CStringFieldIDType*, int) = &AurList<CStringFieldIDType*>::Insert;
int (AurList<CStringFieldIDType*>::*_29)(CStringFieldIDType*) = &AurList<CStringFieldIDType*>::IndexOf;
void (AurList<CStringFieldIDType*>::*_30)(CStringFieldIDType*) = &AurList<CStringFieldIDType*>::Remove;
void (AurList<CStringFieldIDType*>::*_31)(int) = &AurList<CStringFieldIDType*>::DelIndex;
AurList<CStringFieldIDType*>& (AurList<CStringFieldIDType*>::*_32)(AurList<CStringFieldIDType*>&) = &AurList<CStringFieldIDType*>::operator=;
template AurList<unsigned int>::AurList(int);
template AurList<unsigned int>::AurList(AurList<unsigned int>&);
template AurList<unsigned int>::~AurList();
void (AurList<unsigned int>::*_33)(int) = &AurList<unsigned int>::allocate;
void (AurList<unsigned int>::*_34)(int) = &AurList<unsigned int>::SetSize;
void (AurList<unsigned int>::*_35)() = &AurList<unsigned int>::Pack;
void (AurList<unsigned int>::*_36)(unsigned int) = &AurList<unsigned int>::Add;
void (AurList<unsigned int>::*_37)(unsigned int) = &AurList<unsigned int>::AddUnique;
bool (AurList<unsigned int>::*_38)(unsigned int) = &AurList<unsigned int>::Contains;
void (AurList<unsigned int>::*_39)(unsigned int, int) = &AurList<unsigned int>::Insert;
int (AurList<unsigned int>::*_40)(unsigned int) = &AurList<unsigned int>::IndexOf;
void (AurList<unsigned int>::*_41)(unsigned int) = &AurList<unsigned int>::Remove;
void (AurList<unsigned int>::*_42)(int) = &AurList<unsigned int>::DelIndex;
AurList<unsigned int>& (AurList<unsigned int>::*_43)(AurList<unsigned int>&) = &AurList<unsigned int>::operator=;
extern "C" { void c__N_NWSync_S_CNWSync_CNWSync(void* __instance) { ::new (__instance) NWSync::CNWSync(); } }
extern "C" { void c__N_NWSync_S_CNWSync_CNWSync___1__N_NWSync_S_CNWSync(void* __instance, const NWSync::CNWSync& _0) { ::new (__instance) NWSync::CNWSync(_0); } }
NWSync::CNWSync& (NWSync::CNWSync::*_44)(NWSync::CNWSync&&) = &NWSync::CNWSync::operator=;
const char* (*_45)(const unsigned int) = &NWNXLib::API::Constants::ObjectType::ToString;
const char* (*_46)(const unsigned int) = &NWNXLib::API::Constants::AIPriority::ToString;
const char* (*_47)(const unsigned int) = &NWNXLib::API::Constants::ResRefType::ToString;
const char* (*_48)(const unsigned int) = &NWNXLib::API::Constants::ClassType::ToString;
const char* (*_49)(const unsigned int) = &NWNXLib::API::Constants::RacialType::ToString;
const char* (*_50)(const unsigned int) = &NWNXLib::API::Constants::Skill::ToString;
const char* (*_51)(const unsigned int) = &NWNXLib::API::Constants::Feat::ToString;
const char* (*_52)(const unsigned int) = &NWNXLib::API::Constants::Ability::ToString;
const char* (*_53)(const unsigned int) = &NWNXLib::API::Constants::CreatureSize::ToString;
const char* (*_54)(const unsigned int) = &NWNXLib::API::Constants::ACBonus::ToString;
const char* (*_55)(const unsigned int) = &NWNXLib::API::Constants::SavingThrow::ToString;
const char* (*_56)(const unsigned int) = &NWNXLib::API::Constants::SavingThrowType::ToString;
const char* (*_57)(const unsigned int) = &NWNXLib::API::Constants::DamageType::ToString;
const char* (*_58)(const unsigned int) = &NWNXLib::API::Constants::ImmunityType::ToString;
const char* (*_59)(const unsigned int) = &NWNXLib::API::Constants::ToggleMode::ToString;
const char* (*_60)(const unsigned int) = &NWNXLib::API::Constants::CombatMode::ToString;
const char* (*_61)(const unsigned int) = &NWNXLib::API::Constants::Alignment::ToString;
const char* (*_62)(const unsigned int) = &NWNXLib::API::Constants::MovementRate::ToString;
const char* (*_63)(const unsigned int) = &NWNXLib::API::Constants::InventorySlot::ToString;
const char* (*_64)(const unsigned int) = &NWNXLib::API::Constants::EquipmentSlot::ToString;
const char* (*_65)(const unsigned int) = &NWNXLib::API::Constants::BaseItem::ToString;
const char* (*_66)(const int) = &NWNXLib::API::Constants::ItemAppearance::ToString;
const char* (*_67)(const unsigned int) = &NWNXLib::API::Constants::ItemAppearanceType::ToString;
const char* (*_68)(const int) = &NWNXLib::API::Constants::ItemProperty::ToString;
const char* (*_69)(const unsigned int) = &NWNXLib::API::Constants::EffectTrueType::ToString;
const char* (*_70)(const unsigned int) = &NWNXLib::API::Constants::EffectDurationType::ToString;
const char* (*_71)(const unsigned int) = &NWNXLib::API::Constants::EffectSubType::ToString;
const char* (*_72)(const unsigned int) = &NWNXLib::API::Constants::CreatureEvent::ToString;
const char* (*_73)(const unsigned int) = &NWNXLib::API::Constants::Event::ToString;
const char* (*_74)(const unsigned int) = &NWNXLib::API::Constants::ScriptEvent::ToString;
const char* (*_75)(const unsigned int) = &NWNXLib::API::Constants::QuickbarType::ToString;
const char* (*_76)(const unsigned int) = &NWNXLib::API::Constants::ChatChannel::ToString;
const char* (*_77)(const unsigned int) = &NWNXLib::API::Constants::PvPSetting::ToString;
const char* (*_78)(const unsigned int) = &NWNXLib::API::Constants::CharacterType::ToString;
const char* (*_79)(const unsigned int) = &NWNXLib::API::Constants::ObjectVisualTransform::ToString;
const char* (*_80)(const unsigned int) = &NWNXLib::API::Constants::AssociateType::ToString;
const char* (*_81)(const unsigned int) = &NWNXLib::API::Constants::Animation::ToString;
const char* (*_82)(const unsigned int) = &NWNXLib::API::Constants::MessageMajor::ToString;
const char* (*_83)(const unsigned int) = &NWNXLib::API::Constants::MessageServerStatusMinor::ToString;
const char* (*_84)(const unsigned int) = &NWNXLib::API::Constants::MessageLoginMinor::ToString;
const char* (*_85)(const unsigned int) = &NWNXLib::API::Constants::MessageModuleMinor::ToString;
const char* (*_86)(const unsigned int) = &NWNXLib::API::Constants::MessageAreaMinor::ToString;
const char* (*_87)(const unsigned int) = &NWNXLib::API::Constants::MessageGameObjectUpdateMinor::ToString;
const char* (*_88)(const unsigned int) = &NWNXLib::API::Constants::MessageInputMinor::ToString;
const char* (*_89)(const unsigned int) = &NWNXLib::API::Constants::MessageStoreMinor::ToString;
const char* (*_90)(const unsigned int) = &NWNXLib::API::Constants::MessageChatMinor::ToString;
const char* (*_91)(const unsigned int) = &NWNXLib::API::Constants::MessagePlayerListMinor::ToString;
const char* (*_92)(const unsigned int) = &NWNXLib::API::Constants::MessageInventoryMinor::ToString;
const char* (*_93)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiInventoryMinor::ToString;
const char* (*_94)(const unsigned int) = &NWNXLib::API::Constants::MessagePartyMinor::ToString;
const char* (*_95)(const unsigned int) = &NWNXLib::API::Constants::MessageCheatMinor::ToString;
const char* (*_96)(const unsigned int) = &NWNXLib::API::Constants::MessageCameraMinor::ToString;
const char* (*_97)(const unsigned int) = &NWNXLib::API::Constants::MessageCharListMinor::ToString;
const char* (*_98)(const unsigned int) = &NWNXLib::API::Constants::MessageClientSideMsgMinor::ToString;
const char* (*_99)(const unsigned int) = &NWNXLib::API::Constants::MessageCombatMinor::ToString;
const char* (*_100)(const unsigned int) = &NWNXLib::API::Constants::MessageDialogMinor::ToString;
const char* (*_101)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiCharacterSheetMinor::ToString;
const char* (*_102)(const unsigned int) = &NWNXLib::API::Constants::MessageSoundMinor::ToString;
const char* (*_103)(const unsigned int) = &NWNXLib::API::Constants::MessageItemPropertyMinor::ToString;
const char* (*_104)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiContainerMinor::ToString;
const char* (*_105)(const unsigned int) = &NWNXLib::API::Constants::MessageVoiceChatMinor::ToString;
const char* (*_106)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiInfoPopupMinor::ToString;
const char* (*_107)(const unsigned int) = &NWNXLib::API::Constants::MessageJournalMinor::ToString;
const char* (*_108)(const unsigned int) = &NWNXLib::API::Constants::MessageLevelUpMinor::ToString;
const char* (*_109)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiQuickbarMinor::ToString;
const char* (*_110)(const unsigned int) = &NWNXLib::API::Constants::MessageDungeonMasterMinor::ToString;
const char* (*_111)(const unsigned int) = &NWNXLib::API::Constants::MessageMapPinMinor::ToString;
const char* (*_112)(const unsigned int) = &NWNXLib::API::Constants::MessageDebugInfoMinor::ToString;
const char* (*_113)(const unsigned int) = &NWNXLib::API::Constants::MessageSafeProjectileMinor::ToString;
const char* (*_114)(const unsigned int) = &NWNXLib::API::Constants::MessageBarterMinor::ToString;
const char* (*_115)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiPanelMinor::ToString;
const char* (*_116)(const unsigned int) = &NWNXLib::API::Constants::MessageDeathMinor::ToString;
const char* (*_117)(const unsigned int) = &NWNXLib::API::Constants::MessageAmbientMinor::ToString;
const char* (*_118)(const unsigned int) = &NWNXLib::API::Constants::MessagePVPMinor::ToString;
const char* (*_119)(const unsigned int) = &NWNXLib::API::Constants::MessagePortalMinor::ToString;
const char* (*_120)(const unsigned int) = &NWNXLib::API::Constants::MessageCharacterDownloadMinor::ToString;
const char* (*_121)(const unsigned int) = &NWNXLib::API::Constants::MessageLoadBarMinor::ToString;
const char* (*_122)(const unsigned int) = &NWNXLib::API::Constants::MessageSaveLoadMinor::ToString;
const char* (*_123)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiPartyBarMinor::ToString;
const char* (*_124)(const unsigned int) = &NWNXLib::API::Constants::MessageGuiTimingEventMinor::ToString;
const char* (*_125)(const unsigned int) = &NWNXLib::API::Constants::MessagePlayModuleCharacterListMinor::ToString;
const char* (*_126)(const unsigned int) = &NWNXLib::API::Constants::MessageCustomTokenMinor::ToString;
const char* (*_127)(const unsigned int) = &NWNXLib::API::Constants::MessageCutsceneMinor::ToString;
extern "C" { void BIFFFILE_HEADER_BIFFFILE_HEADER(void* __instance) { ::new (__instance) BIFFFILE_HEADER(); } }
extern "C" { void BIFFFILE_HEADER_BIFFFILE_HEADER___1__S_BIFFFILE_HEADER(void* __instance, const BIFFFILE_HEADER& _0) { ::new (__instance) BIFFFILE_HEADER(_0); } }
BIFFFILE_HEADER& (BIFFFILE_HEADER::*_128)(BIFFFILE_HEADER&&) = &BIFFFILE_HEADER::operator=;
extern "C" { void BIFFFILE_VARRESENTRY_E1_BIFFFILE_VARRESENTRY_E1(void* __instance) { ::new (__instance) BIFFFILE_VARRESENTRY_E1(); } }
extern "C" { void BIFFFILE_VARRESENTRY_E1_BIFFFILE_VARRESENTRY_E1___1__S_BIFFFILE_VARRESENTRY_E1(void* __instance, const BIFFFILE_VARRESENTRY_E1& _0) { ::new (__instance) BIFFFILE_VARRESENTRY_E1(_0); } }
BIFFFILE_VARRESENTRY_E1& (BIFFFILE_VARRESENTRY_E1::*_129)(BIFFFILE_VARRESENTRY_E1&&) = &BIFFFILE_VARRESENTRY_E1::operator=;
extern "C" { void BIFFFILE_VARRESENTRY_V1_BIFFFILE_VARRESENTRY_V1(void* __instance) { ::new (__instance) BIFFFILE_VARRESENTRY_V1(); } }
extern "C" { void BIFFFILE_VARRESENTRY_V1_BIFFFILE_VARRESENTRY_V1___1__S_BIFFFILE_VARRESENTRY_V1(void* __instance, const BIFFFILE_VARRESENTRY_V1& _0) { ::new (__instance) BIFFFILE_VARRESENTRY_V1(_0); } }
BIFFFILE_VARRESENTRY_V1& (BIFFFILE_VARRESENTRY_V1::*_130)(BIFFFILE_VARRESENTRY_V1&&) = &BIFFFILE_VARRESENTRY_V1::operator=;
extern "C" { void C2DA_C2DA___1__S_C2DA(void* __instance, const C2DA& _0) { ::new (__instance) C2DA(_0); } }
C2DA& (C2DA::*_131)(const C2DA&) = &C2DA::operator=;
RESID& (RESID::*_132)(RESID&&) = &RESID::operator=;
extern "C" { void RESID_RESID___1__S_RESID(void* __instance, const RESID& _0) { ::new (__instance) RESID(_0); } }
extern "C" { void RESID_RESID(void* __instance) { ::new (__instance) RESID(); } }
CRes& (CRes::*_133)(const CRes&) = &CRes::operator=;
extern "C" { void CRes_CRes___1__S_CRes(void* __instance, const CRes& _0) { ::new (__instance) CRes(_0); } }
extern "C" { void CRes2DA_CRes2DA___1__S_CRes2DA(void* __instance, const CRes2DA& _0) { ::new (__instance) CRes2DA(_0); } }
CRes2DA& (CRes2DA::*_134)(const CRes2DA&) = &CRes2DA::operator=;
extern "C" { void CResRef_CResRef___1__S_CResRef(void* __instance, const CResRef& _0) { ::new (__instance) CResRef(_0); } }
extern "C" { void CachedRulesetEntry_CachedRulesetEntry___1__S_CachedRulesetEntry(void* __instance, const CachedRulesetEntry& _0) { ::new (__instance) CachedRulesetEntry(_0); } }
CachedRulesetEntry& (CachedRulesetEntry::*_135)(CachedRulesetEntry&&) = &CachedRulesetEntry::operator=;
extern "C" { void CachedRulesetEntry__CachedRulesetEntry(CachedRulesetEntry* __instance) { delete __instance; } };
extern "C" { void CachedRulesetEntry_CachedRulesetEntry(void* __instance) { ::new (__instance) CachedRulesetEntry(); } }
extern "C" { void CAppManager_CAppManager___1__S_CAppManager(void* __instance, const CAppManager& _0) { ::new (__instance) CAppManager(_0); } }
CAppManager& (CAppManager::*_136)(const CAppManager&) = &CAppManager::operator=;
extern "C" { void CAurObjectVisualTransformData_CAurObjectVisualTransformData(void* __instance) { ::new (__instance) CAurObjectVisualTransformData(); } }
extern "C" { void CAurObjectVisualTransformData_CAurObjectVisualTransformData___1__S_CAurObjectVisualTransformData(void* __instance, const CAurObjectVisualTransformData& _0) { ::new (__instance) CAurObjectVisualTransformData(_0); } }
CAurObjectVisualTransformData& (CAurObjectVisualTransformData::*_137)(CAurObjectVisualTransformData&&) = &CAurObjectVisualTransformData::operator=;
extern "C" { void Vector_Vector(void* __instance) { ::new (__instance) Vector(); } }
extern "C" { void Vector_Vector___1__S_Vector(void* __instance, const Vector& _0) { ::new (__instance) Vector(_0); } }
Vector& (Vector::*_138)(Vector&&) = &Vector::operator=;
extern "C" { void CAutoSave_CAutoSave(void* __instance) { ::new (__instance) CAutoSave(); } }
extern "C" { void CAutoSave_CAutoSave___1__S_CAutoSave(void* __instance, const CAutoSave& _0) { ::new (__instance) CAutoSave(_0); } }
CAutoSave& (CAutoSave::*_139)(CAutoSave&&) = &CAutoSave::operator=;
template CExoArrayList<CExoString>::CExoArrayList(int);
template CExoArrayList<CExoString>::CExoArrayList(const CExoArrayList<CExoString>&);
template CExoArrayList<CExoString>::~CExoArrayList() noexcept;
CExoArrayList<CExoString>& (CExoArrayList<CExoString>::*_140)(const CExoArrayList<CExoString>&) = &CExoArrayList<CExoString>::operator=;
CExoString& (CExoArrayList<CExoString>::*_141)(int) const = &CExoArrayList<CExoString>::operator[];
void (CExoArrayList<CExoString>::*_142)(int) = &CExoArrayList<CExoString>::Allocate;
void (CExoArrayList<CExoString>::*_143)(int) = &CExoArrayList<CExoString>::SetSize;
void (CExoArrayList<CExoString>::*_144)() = &CExoArrayList<CExoString>::Pack;
void (CExoArrayList<CExoString>::*_145)(CExoString) = &CExoArrayList<CExoString>::Add;
int (CExoArrayList<CExoString>::*_146)(CExoString) = &CExoArrayList<CExoString>::AddUnique;
int (CExoArrayList<CExoString>::*_147)(CExoString) = &CExoArrayList<CExoString>::Contains;
void (CExoArrayList<CExoString>::*_148)(CExoString, int) = &CExoArrayList<CExoString>::Insert;
int (CExoArrayList<CExoString>::*_149)(CExoString) = &CExoArrayList<CExoString>::IndexOf;
void (CExoArrayList<CExoString>::*_150)(CExoString) = &CExoArrayList<CExoString>::Remove;
void (CExoArrayList<CExoString>::*_151)(int) = &CExoArrayList<CExoString>::DelIndex;
CExoString* (CExoArrayList<CExoString>::*_152)() = &CExoArrayList<CExoString>::begin;
CExoString* (CExoArrayList<CExoString>::*_153)() = &CExoArrayList<CExoString>::end;
CBaseExoApp& (CBaseExoApp::*_154)(CBaseExoApp&&) = &CBaseExoApp::operator=;
extern "C" { void CBaseExoApp_CBaseExoApp(void* __instance) { ::new (__instance) CBaseExoApp(); } }
extern "C" { void CBaseExoApp_CBaseExoApp___1__S_CBaseExoApp(void* __instance, const CBaseExoApp& _0) { ::new (__instance) CBaseExoApp(_0); } }
template CExoArrayList<CCombatInformationNode*>::CExoArrayList(int);
template CExoArrayList<CCombatInformationNode*>::CExoArrayList(const CExoArrayList<CCombatInformationNode*>&);
template CExoArrayList<CCombatInformationNode*>::~CExoArrayList() noexcept;
CExoArrayList<CCombatInformationNode*>& (CExoArrayList<CCombatInformationNode*>::*_155)(const CExoArrayList<CCombatInformationNode*>&) = &CExoArrayList<CCombatInformationNode*>::operator=;
CCombatInformationNode*& (CExoArrayList<CCombatInformationNode*>::*_156)(int) const = &CExoArrayList<CCombatInformationNode*>::operator[];
void (CExoArrayList<CCombatInformationNode*>::*_157)(int) = &CExoArrayList<CCombatInformationNode*>::Allocate;
void (CExoArrayList<CCombatInformationNode*>::*_158)(int) = &CExoArrayList<CCombatInformationNode*>::SetSize;
void (CExoArrayList<CCombatInformationNode*>::*_159)() = &CExoArrayList<CCombatInformationNode*>::Pack;
void (CExoArrayList<CCombatInformationNode*>::*_160)(CCombatInformationNode*) = &CExoArrayList<CCombatInformationNode*>::Add;
int (CExoArrayList<CCombatInformationNode*>::*_161)(CCombatInformationNode*) = &CExoArrayList<CCombatInformationNode*>::AddUnique;
int (CExoArrayList<CCombatInformationNode*>::*_162)(CCombatInformationNode*) = &CExoArrayList<CCombatInformationNode*>::Contains;
int (CExoArrayList<CCombatInformationNode*>::*_163)(CCombatInformationNode*) = &CExoArrayList<CCombatInformationNode*>::DerefContains;
void (CExoArrayList<CCombatInformationNode*>::*_164)(CCombatInformationNode*, int) = &CExoArrayList<CCombatInformationNode*>::Insert;
int (CExoArrayList<CCombatInformationNode*>::*_165)(CCombatInformationNode*) = &CExoArrayList<CCombatInformationNode*>::IndexOf;
void (CExoArrayList<CCombatInformationNode*>::*_166)(CCombatInformationNode*) = &CExoArrayList<CCombatInformationNode*>::Remove;
void (CExoArrayList<CCombatInformationNode*>::*_167)(int) = &CExoArrayList<CCombatInformationNode*>::DelIndex;
CCombatInformationNode** (CExoArrayList<CCombatInformationNode*>::*_168)() = &CExoArrayList<CCombatInformationNode*>::begin;
CCombatInformationNode** (CExoArrayList<CCombatInformationNode*>::*_169)() = &CExoArrayList<CCombatInformationNode*>::end;
template CExoArrayList<CFileInfo>::CExoArrayList(int);
template CExoArrayList<CFileInfo>::CExoArrayList(const CExoArrayList<CFileInfo>&);
template CExoArrayList<CFileInfo>::~CExoArrayList() noexcept;
CExoArrayList<CFileInfo>& (CExoArrayList<CFileInfo>::*_170)(const CExoArrayList<CFileInfo>&) = &CExoArrayList<CFileInfo>::operator=;
CFileInfo& (CExoArrayList<CFileInfo>::*_171)(int) const = &CExoArrayList<CFileInfo>::operator[];
void (CExoArrayList<CFileInfo>::*_172)(int) = &CExoArrayList<CFileInfo>::Allocate;
void (CExoArrayList<CFileInfo>::*_173)(int) = &CExoArrayList<CFileInfo>::SetSize;
void (CExoArrayList<CFileInfo>::*_174)() = &CExoArrayList<CFileInfo>::Pack;
void (CExoArrayList<CFileInfo>::*_175)(CFileInfo) = &CExoArrayList<CFileInfo>::Add;
void (CExoArrayList<CFileInfo>::*_176)(CFileInfo, int) = &CExoArrayList<CFileInfo>::Insert;
void (CExoArrayList<CFileInfo>::*_177)(int) = &CExoArrayList<CFileInfo>::DelIndex;
CFileInfo* (CExoArrayList<CFileInfo>::*_178)() = &CExoArrayList<CFileInfo>::begin;
CFileInfo* (CExoArrayList<CFileInfo>::*_179)() = &CExoArrayList<CFileInfo>::end;
template CExoArrayList<CExoKeyTable*>::CExoArrayList(int);
template CExoArrayList<CExoKeyTable*>::CExoArrayList(const CExoArrayList<CExoKeyTable*>&);
template CExoArrayList<CExoKeyTable*>::~CExoArrayList() noexcept;
CExoArrayList<CExoKeyTable*>& (CExoArrayList<CExoKeyTable*>::*_180)(const CExoArrayList<CExoKeyTable*>&) = &CExoArrayList<CExoKeyTable*>::operator=;
CExoKeyTable*& (CExoArrayList<CExoKeyTable*>::*_181)(int) const = &CExoArrayList<CExoKeyTable*>::operator[];
void (CExoArrayList<CExoKeyTable*>::*_182)(int) = &CExoArrayList<CExoKeyTable*>::Allocate;
void (CExoArrayList<CExoKeyTable*>::*_183)(int) = &CExoArrayList<CExoKeyTable*>::SetSize;
void (CExoArrayList<CExoKeyTable*>::*_184)() = &CExoArrayList<CExoKeyTable*>::Pack;
void (CExoArrayList<CExoKeyTable*>::*_185)(CExoKeyTable*) = &CExoArrayList<CExoKeyTable*>::Add;
int (CExoArrayList<CExoKeyTable*>::*_186)(CExoKeyTable*) = &CExoArrayList<CExoKeyTable*>::AddUnique;
int (CExoArrayList<CExoKeyTable*>::*_187)(CExoKeyTable*) = &CExoArrayList<CExoKeyTable*>::Contains;
int (CExoArrayList<CExoKeyTable*>::*_188)(CExoKeyTable*) = &CExoArrayList<CExoKeyTable*>::DerefContains;
void (CExoArrayList<CExoKeyTable*>::*_189)(CExoKeyTable*, int) = &CExoArrayList<CExoKeyTable*>::Insert;
int (CExoArrayList<CExoKeyTable*>::*_190)(CExoKeyTable*) = &CExoArrayList<CExoKeyTable*>::IndexOf;
void (CExoArrayList<CExoKeyTable*>::*_191)(CExoKeyTable*) = &CExoArrayList<CExoKeyTable*>::Remove;
void (CExoArrayList<CExoKeyTable*>::*_192)(int) = &CExoArrayList<CExoKeyTable*>::DelIndex;
CExoKeyTable** (CExoArrayList<CExoKeyTable*>::*_193)() = &CExoArrayList<CExoKeyTable*>::begin;
CExoKeyTable** (CExoArrayList<CExoKeyTable*>::*_194)() = &CExoArrayList<CExoKeyTable*>::end;
template CExoArrayList<int>::CExoArrayList(int);
template CExoArrayList<int>::CExoArrayList(const CExoArrayList<int>&);
template CExoArrayList<int>::~CExoArrayList() noexcept;
CExoArrayList<int>& (CExoArrayList<int>::*_195)(const CExoArrayList<int>&) = &CExoArrayList<int>::operator=;
int& (CExoArrayList<int>::*_196)(int) const = &CExoArrayList<int>::operator[];
void (CExoArrayList<int>::*_197)(int) = &CExoArrayList<int>::Allocate;
void (CExoArrayList<int>::*_198)(int) = &CExoArrayList<int>::SetSize;
void (CExoArrayList<int>::*_199)() = &CExoArrayList<int>::Pack;
void (CExoArrayList<int>::*_200)(int) = &CExoArrayList<int>::Add;
int (CExoArrayList<int>::*_201)(int) = &CExoArrayList<int>::AddUnique;
int (CExoArrayList<int>::*_202)(int) = &CExoArrayList<int>::Contains;
void (CExoArrayList<int>::*_203)(int, int) = &CExoArrayList<int>::Insert;
int (CExoArrayList<int>::*_204)(int) = &CExoArrayList<int>::IndexOf;
void (CExoArrayList<int>::*_205)(int) = &CExoArrayList<int>::Remove;
void (CExoArrayList<int>::*_206)(int) = &CExoArrayList<int>::DelIndex;
int* (CExoArrayList<int>::*_207)() = &CExoArrayList<int>::begin;
int* (CExoArrayList<int>::*_208)() = &CExoArrayList<int>::end;
template CExoArrayList<CLoopingVisualEffect*>::CExoArrayList(int);
template CExoArrayList<CLoopingVisualEffect*>::CExoArrayList(const CExoArrayList<CLoopingVisualEffect*>&);
template CExoArrayList<CLoopingVisualEffect*>::~CExoArrayList() noexcept;
CExoArrayList<CLoopingVisualEffect*>& (CExoArrayList<CLoopingVisualEffect*>::*_209)(const CExoArrayList<CLoopingVisualEffect*>&) = &CExoArrayList<CLoopingVisualEffect*>::operator=;
CLoopingVisualEffect*& (CExoArrayList<CLoopingVisualEffect*>::*_210)(int) const = &CExoArrayList<CLoopingVisualEffect*>::operator[];
void (CExoArrayList<CLoopingVisualEffect*>::*_211)(int) = &CExoArrayList<CLoopingVisualEffect*>::Allocate;
void (CExoArrayList<CLoopingVisualEffect*>::*_212)(int) = &CExoArrayList<CLoopingVisualEffect*>::SetSize;
void (CExoArrayList<CLoopingVisualEffect*>::*_213)() = &CExoArrayList<CLoopingVisualEffect*>::Pack;
void (CExoArrayList<CLoopingVisualEffect*>::*_214)(CLoopingVisualEffect*) = &CExoArrayList<CLoopingVisualEffect*>::Add;
int (CExoArrayList<CLoopingVisualEffect*>::*_215)(CLoopingVisualEffect*) = &CExoArrayList<CLoopingVisualEffect*>::AddUnique;
int (CExoArrayList<CLoopingVisualEffect*>::*_216)(CLoopingVisualEffect*) = &CExoArrayList<CLoopingVisualEffect*>::Contains;
int (CExoArrayList<CLoopingVisualEffect*>::*_217)(CLoopingVisualEffect*) = &CExoArrayList<CLoopingVisualEffect*>::DerefContains;
void (CExoArrayList<CLoopingVisualEffect*>::*_218)(CLoopingVisualEffect*, int) = &CExoArrayList<CLoopingVisualEffect*>::Insert;
int (CExoArrayList<CLoopingVisualEffect*>::*_219)(CLoopingVisualEffect*) = &CExoArrayList<CLoopingVisualEffect*>::IndexOf;
void (CExoArrayList<CLoopingVisualEffect*>::*_220)(CLoopingVisualEffect*) = &CExoArrayList<CLoopingVisualEffect*>::Remove;
void (CExoArrayList<CLoopingVisualEffect*>::*_221)(int) = &CExoArrayList<CLoopingVisualEffect*>::DelIndex;
CLoopingVisualEffect** (CExoArrayList<CLoopingVisualEffect*>::*_222)() = &CExoArrayList<CLoopingVisualEffect*>::begin;
CLoopingVisualEffect** (CExoArrayList<CLoopingVisualEffect*>::*_223)() = &CExoArrayList<CLoopingVisualEffect*>::end;
template CExoArrayList<unsigned int>::CExoArrayList(int);
template CExoArrayList<unsigned int>::CExoArrayList(const CExoArrayList<unsigned int>&);
template CExoArrayList<unsigned int>::~CExoArrayList() noexcept;
CExoArrayList<unsigned int>& (CExoArrayList<unsigned int>::*_224)(const CExoArrayList<unsigned int>&) = &CExoArrayList<unsigned int>::operator=;
unsigned int& (CExoArrayList<unsigned int>::*_225)(int) const = &CExoArrayList<unsigned int>::operator[];
void (CExoArrayList<unsigned int>::*_226)(int) = &CExoArrayList<unsigned int>::Allocate;
void (CExoArrayList<unsigned int>::*_227)(int) = &CExoArrayList<unsigned int>::SetSize;
void (CExoArrayList<unsigned int>::*_228)() = &CExoArrayList<unsigned int>::Pack;
void (CExoArrayList<unsigned int>::*_229)(unsigned int) = &CExoArrayList<unsigned int>::Add;
int (CExoArrayList<unsigned int>::*_230)(unsigned int) = &CExoArrayList<unsigned int>::AddUnique;
int (CExoArrayList<unsigned int>::*_231)(unsigned int) = &CExoArrayList<unsigned int>::Contains;
void (CExoArrayList<unsigned int>::*_232)(unsigned int, int) = &CExoArrayList<unsigned int>::Insert;
int (CExoArrayList<unsigned int>::*_233)(unsigned int) = &CExoArrayList<unsigned int>::IndexOf;
void (CExoArrayList<unsigned int>::*_234)(unsigned int) = &CExoArrayList<unsigned int>::Remove;
void (CExoArrayList<unsigned int>::*_235)(int) = &CExoArrayList<unsigned int>::DelIndex;
unsigned int* (CExoArrayList<unsigned int>::*_236)() = &CExoArrayList<unsigned int>::begin;
unsigned int* (CExoArrayList<unsigned int>::*_237)() = &CExoArrayList<unsigned int>::end;
template CExoArrayList<MaterialShaderParam>::CExoArrayList(int);
template CExoArrayList<MaterialShaderParam>::CExoArrayList(const CExoArrayList<MaterialShaderParam>&);
template CExoArrayList<MaterialShaderParam>::~CExoArrayList() noexcept;
CExoArrayList<MaterialShaderParam>& (CExoArrayList<MaterialShaderParam>::*_238)(const CExoArrayList<MaterialShaderParam>&) = &CExoArrayList<MaterialShaderParam>::operator=;
MaterialShaderParam& (CExoArrayList<MaterialShaderParam>::*_239)(int) const = &CExoArrayList<MaterialShaderParam>::operator[];
void (CExoArrayList<MaterialShaderParam>::*_240)(int) = &CExoArrayList<MaterialShaderParam>::Allocate;
void (CExoArrayList<MaterialShaderParam>::*_241)(int) = &CExoArrayList<MaterialShaderParam>::SetSize;
void (CExoArrayList<MaterialShaderParam>::*_242)() = &CExoArrayList<MaterialShaderParam>::Pack;
void (CExoArrayList<MaterialShaderParam>::*_243)(MaterialShaderParam) = &CExoArrayList<MaterialShaderParam>::Add;
void (CExoArrayList<MaterialShaderParam>::*_244)(MaterialShaderParam, int) = &CExoArrayList<MaterialShaderParam>::Insert;
void (CExoArrayList<MaterialShaderParam>::*_245)(int) = &CExoArrayList<MaterialShaderParam>::DelIndex;
MaterialShaderParam* (CExoArrayList<MaterialShaderParam>::*_246)() = &CExoArrayList<MaterialShaderParam>::begin;
MaterialShaderParam* (CExoArrayList<MaterialShaderParam>::*_247)() = &CExoArrayList<MaterialShaderParam>::end;
template CExoArrayList<TextureReplaceInfo>::CExoArrayList(int);
template CExoArrayList<TextureReplaceInfo>::CExoArrayList(const CExoArrayList<TextureReplaceInfo>&);
template CExoArrayList<TextureReplaceInfo>::~CExoArrayList() noexcept;
CExoArrayList<TextureReplaceInfo>& (CExoArrayList<TextureReplaceInfo>::*_248)(const CExoArrayList<TextureReplaceInfo>&) = &CExoArrayList<TextureReplaceInfo>::operator=;
TextureReplaceInfo& (CExoArrayList<TextureReplaceInfo>::*_249)(int) const = &CExoArrayList<TextureReplaceInfo>::operator[];
void (CExoArrayList<TextureReplaceInfo>::*_250)(int) = &CExoArrayList<TextureReplaceInfo>::Allocate;
void (CExoArrayList<TextureReplaceInfo>::*_251)(int) = &CExoArrayList<TextureReplaceInfo>::SetSize;
void (CExoArrayList<TextureReplaceInfo>::*_252)() = &CExoArrayList<TextureReplaceInfo>::Pack;
void (CExoArrayList<TextureReplaceInfo>::*_253)(TextureReplaceInfo) = &CExoArrayList<TextureReplaceInfo>::Add;
void (CExoArrayList<TextureReplaceInfo>::*_254)(TextureReplaceInfo, int) = &CExoArrayList<TextureReplaceInfo>::Insert;
void (CExoArrayList<TextureReplaceInfo>::*_255)(int) = &CExoArrayList<TextureReplaceInfo>::DelIndex;
TextureReplaceInfo* (CExoArrayList<TextureReplaceInfo>::*_256)() = &CExoArrayList<TextureReplaceInfo>::begin;
TextureReplaceInfo* (CExoArrayList<TextureReplaceInfo>::*_257)() = &CExoArrayList<TextureReplaceInfo>::end;
template CExoArrayList<CNetLayerPlayerCDKeyInfo>::CExoArrayList(int);
template CExoArrayList<CNetLayerPlayerCDKeyInfo>::CExoArrayList(const CExoArrayList<CNetLayerPlayerCDKeyInfo>&);
template CExoArrayList<CNetLayerPlayerCDKeyInfo>::~CExoArrayList() noexcept;
CExoArrayList<CNetLayerPlayerCDKeyInfo>& (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_258)(const CExoArrayList<CNetLayerPlayerCDKeyInfo>&) = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::operator=;
CNetLayerPlayerCDKeyInfo& (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_259)(int) const = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::operator[];
void (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_260)(int) = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::Allocate;
void (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_261)(int) = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::SetSize;
void (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_262)() = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::Pack;
void (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_263)(CNetLayerPlayerCDKeyInfo) = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::Add;
void (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_264)(CNetLayerPlayerCDKeyInfo, int) = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::Insert;
void (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_265)(int) = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::DelIndex;
CNetLayerPlayerCDKeyInfo* (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_266)() = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::begin;
CNetLayerPlayerCDKeyInfo* (CExoArrayList<CNetLayerPlayerCDKeyInfo>::*_267)() = &CExoArrayList<CNetLayerPlayerCDKeyInfo>::end;
template CExoArrayList<CGameObject*>::CExoArrayList(int);
template CExoArrayList<CGameObject*>::CExoArrayList(const CExoArrayList<CGameObject*>&);
template CExoArrayList<CGameObject*>::~CExoArrayList() noexcept;
CExoArrayList<CGameObject*>& (CExoArrayList<CGameObject*>::*_268)(const CExoArrayList<CGameObject*>&) = &CExoArrayList<CGameObject*>::operator=;
CGameObject*& (CExoArrayList<CGameObject*>::*_269)(int) const = &CExoArrayList<CGameObject*>::operator[];
void (CExoArrayList<CGameObject*>::*_270)(int) = &CExoArrayList<CGameObject*>::Allocate;
void (CExoArrayList<CGameObject*>::*_271)(int) = &CExoArrayList<CGameObject*>::SetSize;
void (CExoArrayList<CGameObject*>::*_272)() = &CExoArrayList<CGameObject*>::Pack;
void (CExoArrayList<CGameObject*>::*_273)(CGameObject*) = &CExoArrayList<CGameObject*>::Add;
int (CExoArrayList<CGameObject*>::*_274)(CGameObject*) = &CExoArrayList<CGameObject*>::AddUnique;
int (CExoArrayList<CGameObject*>::*_275)(CGameObject*) = &CExoArrayList<CGameObject*>::Contains;
int (CExoArrayList<CGameObject*>::*_276)(CGameObject*) = &CExoArrayList<CGameObject*>::DerefContains;
void (CExoArrayList<CGameObject*>::*_277)(CGameObject*, int) = &CExoArrayList<CGameObject*>::Insert;
int (CExoArrayList<CGameObject*>::*_278)(CGameObject*) = &CExoArrayList<CGameObject*>::IndexOf;
void (CExoArrayList<CGameObject*>::*_279)(CGameObject*) = &CExoArrayList<CGameObject*>::Remove;
void (CExoArrayList<CGameObject*>::*_280)(int) = &CExoArrayList<CGameObject*>::DelIndex;
CGameObject** (CExoArrayList<CGameObject*>::*_281)() = &CExoArrayList<CGameObject*>::begin;
CGameObject** (CExoArrayList<CGameObject*>::*_282)() = &CExoArrayList<CGameObject*>::end;
template CExoArrayList<float>::CExoArrayList(int);
template CExoArrayList<float>::CExoArrayList(const CExoArrayList<float>&);
template CExoArrayList<float>::~CExoArrayList() noexcept;
CExoArrayList<float>& (CExoArrayList<float>::*_283)(const CExoArrayList<float>&) = &CExoArrayList<float>::operator=;
float& (CExoArrayList<float>::*_284)(int) const = &CExoArrayList<float>::operator[];
void (CExoArrayList<float>::*_285)(int) = &CExoArrayList<float>::Allocate;
void (CExoArrayList<float>::*_286)(int) = &CExoArrayList<float>::SetSize;
void (CExoArrayList<float>::*_287)() = &CExoArrayList<float>::Pack;
void (CExoArrayList<float>::*_288)(float) = &CExoArrayList<float>::Add;
int (CExoArrayList<float>::*_289)(float) = &CExoArrayList<float>::AddUnique;
int (CExoArrayList<float>::*_290)(float) = &CExoArrayList<float>::Contains;
void (CExoArrayList<float>::*_291)(float, int) = &CExoArrayList<float>::Insert;
int (CExoArrayList<float>::*_292)(float) = &CExoArrayList<float>::IndexOf;
void (CExoArrayList<float>::*_293)(float) = &CExoArrayList<float>::Remove;
void (CExoArrayList<float>::*_294)(int) = &CExoArrayList<float>::DelIndex;
float* (CExoArrayList<float>::*_295)() = &CExoArrayList<float>::begin;
float* (CExoArrayList<float>::*_296)() = &CExoArrayList<float>::end;
template CExoArrayList<unsigned short>::CExoArrayList(int);
template CExoArrayList<unsigned short>::CExoArrayList(const CExoArrayList<unsigned short>&);
template CExoArrayList<unsigned short>::~CExoArrayList() noexcept;
CExoArrayList<unsigned short>& (CExoArrayList<unsigned short>::*_297)(const CExoArrayList<unsigned short>&) = &CExoArrayList<unsigned short>::operator=;
unsigned short& (CExoArrayList<unsigned short>::*_298)(int) const = &CExoArrayList<unsigned short>::operator[];
void (CExoArrayList<unsigned short>::*_299)(int) = &CExoArrayList<unsigned short>::Allocate;
void (CExoArrayList<unsigned short>::*_300)(int) = &CExoArrayList<unsigned short>::SetSize;
void (CExoArrayList<unsigned short>::*_301)() = &CExoArrayList<unsigned short>::Pack;
void (CExoArrayList<unsigned short>::*_302)(unsigned short) = &CExoArrayList<unsigned short>::Add;
int (CExoArrayList<unsigned short>::*_303)(unsigned short) = &CExoArrayList<unsigned short>::AddUnique;
int (CExoArrayList<unsigned short>::*_304)(unsigned short) = &CExoArrayList<unsigned short>::Contains;
void (CExoArrayList<unsigned short>::*_305)(unsigned short, int) = &CExoArrayList<unsigned short>::Insert;
int (CExoArrayList<unsigned short>::*_306)(unsigned short) = &CExoArrayList<unsigned short>::IndexOf;
void (CExoArrayList<unsigned short>::*_307)(unsigned short) = &CExoArrayList<unsigned short>::Remove;
void (CExoArrayList<unsigned short>::*_308)(int) = &CExoArrayList<unsigned short>::DelIndex;
unsigned short* (CExoArrayList<unsigned short>::*_309)() = &CExoArrayList<unsigned short>::begin;
unsigned short* (CExoArrayList<unsigned short>::*_310)() = &CExoArrayList<unsigned short>::end;
template CExoArrayList<CEffectIconObject*>::CExoArrayList(int);
template CExoArrayList<CEffectIconObject*>::CExoArrayList(const CExoArrayList<CEffectIconObject*>&);
template CExoArrayList<CEffectIconObject*>::~CExoArrayList() noexcept;
CExoArrayList<CEffectIconObject*>& (CExoArrayList<CEffectIconObject*>::*_311)(const CExoArrayList<CEffectIconObject*>&) = &CExoArrayList<CEffectIconObject*>::operator=;
CEffectIconObject*& (CExoArrayList<CEffectIconObject*>::*_312)(int) const = &CExoArrayList<CEffectIconObject*>::operator[];
void (CExoArrayList<CEffectIconObject*>::*_313)(int) = &CExoArrayList<CEffectIconObject*>::Allocate;
void (CExoArrayList<CEffectIconObject*>::*_314)(int) = &CExoArrayList<CEffectIconObject*>::SetSize;
void (CExoArrayList<CEffectIconObject*>::*_315)() = &CExoArrayList<CEffectIconObject*>::Pack;
void (CExoArrayList<CEffectIconObject*>::*_316)(CEffectIconObject*) = &CExoArrayList<CEffectIconObject*>::Add;
int (CExoArrayList<CEffectIconObject*>::*_317)(CEffectIconObject*) = &CExoArrayList<CEffectIconObject*>::AddUnique;
int (CExoArrayList<CEffectIconObject*>::*_318)(CEffectIconObject*) = &CExoArrayList<CEffectIconObject*>::Contains;
int (CExoArrayList<CEffectIconObject*>::*_319)(CEffectIconObject*) = &CExoArrayList<CEffectIconObject*>::DerefContains;
void (CExoArrayList<CEffectIconObject*>::*_320)(CEffectIconObject*, int) = &CExoArrayList<CEffectIconObject*>::Insert;
int (CExoArrayList<CEffectIconObject*>::*_321)(CEffectIconObject*) = &CExoArrayList<CEffectIconObject*>::IndexOf;
void (CExoArrayList<CEffectIconObject*>::*_322)(CEffectIconObject*) = &CExoArrayList<CEffectIconObject*>::Remove;
void (CExoArrayList<CEffectIconObject*>::*_323)(int) = &CExoArrayList<CEffectIconObject*>::DelIndex;
CEffectIconObject** (CExoArrayList<CEffectIconObject*>::*_324)() = &CExoArrayList<CEffectIconObject*>::begin;
CEffectIconObject** (CExoArrayList<CEffectIconObject*>::*_325)() = &CExoArrayList<CEffectIconObject*>::end;
template CExoArrayList<CGameEffect*>::CExoArrayList(int);
template CExoArrayList<CGameEffect*>::CExoArrayList(const CExoArrayList<CGameEffect*>&);
template CExoArrayList<CGameEffect*>::~CExoArrayList() noexcept;
CExoArrayList<CGameEffect*>& (CExoArrayList<CGameEffect*>::*_326)(const CExoArrayList<CGameEffect*>&) = &CExoArrayList<CGameEffect*>::operator=;
CGameEffect*& (CExoArrayList<CGameEffect*>::*_327)(int) const = &CExoArrayList<CGameEffect*>::operator[];
void (CExoArrayList<CGameEffect*>::*_328)(int) = &CExoArrayList<CGameEffect*>::Allocate;
void (CExoArrayList<CGameEffect*>::*_329)(int) = &CExoArrayList<CGameEffect*>::SetSize;
void (CExoArrayList<CGameEffect*>::*_330)() = &CExoArrayList<CGameEffect*>::Pack;
void (CExoArrayList<CGameEffect*>::*_331)(CGameEffect*) = &CExoArrayList<CGameEffect*>::Add;
int (CExoArrayList<CGameEffect*>::*_332)(CGameEffect*) = &CExoArrayList<CGameEffect*>::AddUnique;
int (CExoArrayList<CGameEffect*>::*_333)(CGameEffect*) = &CExoArrayList<CGameEffect*>::Contains;
int (CExoArrayList<CGameEffect*>::*_334)(CGameEffect*) = &CExoArrayList<CGameEffect*>::DerefContains;
void (CExoArrayList<CGameEffect*>::*_335)(CGameEffect*, int) = &CExoArrayList<CGameEffect*>::Insert;
int (CExoArrayList<CGameEffect*>::*_336)(CGameEffect*) = &CExoArrayList<CGameEffect*>::IndexOf;
void (CExoArrayList<CGameEffect*>::*_337)(CGameEffect*) = &CExoArrayList<CGameEffect*>::Remove;
void (CExoArrayList<CGameEffect*>::*_338)(int) = &CExoArrayList<CGameEffect*>::DelIndex;
CGameEffect** (CExoArrayList<CGameEffect*>::*_339)() = &CExoArrayList<CGameEffect*>::begin;
CGameEffect** (CExoArrayList<CGameEffect*>::*_340)() = &CExoArrayList<CGameEffect*>::end;
template CExoArrayList<CNWSExpression*>::CExoArrayList(int);
template CExoArrayList<CNWSExpression*>::CExoArrayList(const CExoArrayList<CNWSExpression*>&);
template CExoArrayList<CNWSExpression*>::~CExoArrayList() noexcept;
CExoArrayList<CNWSExpression*>& (CExoArrayList<CNWSExpression*>::*_341)(const CExoArrayList<CNWSExpression*>&) = &CExoArrayList<CNWSExpression*>::operator=;
CNWSExpression*& (CExoArrayList<CNWSExpression*>::*_342)(int) const = &CExoArrayList<CNWSExpression*>::operator[];
void (CExoArrayList<CNWSExpression*>::*_343)(int) = &CExoArrayList<CNWSExpression*>::Allocate;
void (CExoArrayList<CNWSExpression*>::*_344)(int) = &CExoArrayList<CNWSExpression*>::SetSize;
void (CExoArrayList<CNWSExpression*>::*_345)() = &CExoArrayList<CNWSExpression*>::Pack;
void (CExoArrayList<CNWSExpression*>::*_346)(CNWSExpression*) = &CExoArrayList<CNWSExpression*>::Add;
int (CExoArrayList<CNWSExpression*>::*_347)(CNWSExpression*) = &CExoArrayList<CNWSExpression*>::AddUnique;
int (CExoArrayList<CNWSExpression*>::*_348)(CNWSExpression*) = &CExoArrayList<CNWSExpression*>::Contains;
int (CExoArrayList<CNWSExpression*>::*_349)(CNWSExpression*) = &CExoArrayList<CNWSExpression*>::DerefContains;
void (CExoArrayList<CNWSExpression*>::*_350)(CNWSExpression*, int) = &CExoArrayList<CNWSExpression*>::Insert;
int (CExoArrayList<CNWSExpression*>::*_351)(CNWSExpression*) = &CExoArrayList<CNWSExpression*>::IndexOf;
void (CExoArrayList<CNWSExpression*>::*_352)(CNWSExpression*) = &CExoArrayList<CNWSExpression*>::Remove;
void (CExoArrayList<CNWSExpression*>::*_353)(int) = &CExoArrayList<CNWSExpression*>::DelIndex;
CNWSExpression** (CExoArrayList<CNWSExpression*>::*_354)() = &CExoArrayList<CNWSExpression*>::begin;
CNWSExpression** (CExoArrayList<CNWSExpression*>::*_355)() = &CExoArrayList<CNWSExpression*>::end;
template CExoArrayList<CExoString*>::CExoArrayList(int);
template CExoArrayList<CExoString*>::CExoArrayList(const CExoArrayList<CExoString*>&);
template CExoArrayList<CExoString*>::~CExoArrayList() noexcept;
CExoArrayList<CExoString*>& (CExoArrayList<CExoString*>::*_356)(const CExoArrayList<CExoString*>&) = &CExoArrayList<CExoString*>::operator=;
CExoString*& (CExoArrayList<CExoString*>::*_357)(int) const = &CExoArrayList<CExoString*>::operator[];
void (CExoArrayList<CExoString*>::*_358)(int) = &CExoArrayList<CExoString*>::Allocate;
void (CExoArrayList<CExoString*>::*_359)(int) = &CExoArrayList<CExoString*>::SetSize;
void (CExoArrayList<CExoString*>::*_360)() = &CExoArrayList<CExoString*>::Pack;
void (CExoArrayList<CExoString*>::*_361)(CExoString*) = &CExoArrayList<CExoString*>::Add;
int (CExoArrayList<CExoString*>::*_362)(CExoString*) = &CExoArrayList<CExoString*>::AddUnique;
int (CExoArrayList<CExoString*>::*_363)(CExoString*) = &CExoArrayList<CExoString*>::Contains;
int (CExoArrayList<CExoString*>::*_364)(CExoString*) = &CExoArrayList<CExoString*>::DerefContains;
void (CExoArrayList<CExoString*>::*_365)(CExoString*, int) = &CExoArrayList<CExoString*>::Insert;
int (CExoArrayList<CExoString*>::*_366)(CExoString*) = &CExoArrayList<CExoString*>::IndexOf;
void (CExoArrayList<CExoString*>::*_367)(CExoString*) = &CExoArrayList<CExoString*>::Remove;
void (CExoArrayList<CExoString*>::*_368)(int) = &CExoArrayList<CExoString*>::DelIndex;
CExoString** (CExoArrayList<CExoString*>::*_369)() = &CExoArrayList<CExoString*>::begin;
CExoString** (CExoArrayList<CExoString*>::*_370)() = &CExoArrayList<CExoString*>::end;
template CExoArrayList<CNWSSpellScriptData*>::CExoArrayList(int);
template CExoArrayList<CNWSSpellScriptData*>::CExoArrayList(const CExoArrayList<CNWSSpellScriptData*>&);
template CExoArrayList<CNWSSpellScriptData*>::~CExoArrayList() noexcept;
CExoArrayList<CNWSSpellScriptData*>& (CExoArrayList<CNWSSpellScriptData*>::*_371)(const CExoArrayList<CNWSSpellScriptData*>&) = &CExoArrayList<CNWSSpellScriptData*>::operator=;
CNWSSpellScriptData*& (CExoArrayList<CNWSSpellScriptData*>::*_372)(int) const = &CExoArrayList<CNWSSpellScriptData*>::operator[];
void (CExoArrayList<CNWSSpellScriptData*>::*_373)(int) = &CExoArrayList<CNWSSpellScriptData*>::Allocate;
void (CExoArrayList<CNWSSpellScriptData*>::*_374)(int) = &CExoArrayList<CNWSSpellScriptData*>::SetSize;
void (CExoArrayList<CNWSSpellScriptData*>::*_375)() = &CExoArrayList<CNWSSpellScriptData*>::Pack;
void (CExoArrayList<CNWSSpellScriptData*>::*_376)(CNWSSpellScriptData*) = &CExoArrayList<CNWSSpellScriptData*>::Add;
int (CExoArrayList<CNWSSpellScriptData*>::*_377)(CNWSSpellScriptData*) = &CExoArrayList<CNWSSpellScriptData*>::AddUnique;
int (CExoArrayList<CNWSSpellScriptData*>::*_378)(CNWSSpellScriptData*) = &CExoArrayList<CNWSSpellScriptData*>::Contains;
int (CExoArrayList<CNWSSpellScriptData*>::*_379)(CNWSSpellScriptData*) = &CExoArrayList<CNWSSpellScriptData*>::DerefContains;
void (CExoArrayList<CNWSSpellScriptData*>::*_380)(CNWSSpellScriptData*, int) = &CExoArrayList<CNWSSpellScriptData*>::Insert;
int (CExoArrayList<CNWSSpellScriptData*>::*_381)(CNWSSpellScriptData*) = &CExoArrayList<CNWSSpellScriptData*>::IndexOf;
void (CExoArrayList<CNWSSpellScriptData*>::*_382)(CNWSSpellScriptData*) = &CExoArrayList<CNWSSpellScriptData*>::Remove;
void (CExoArrayList<CNWSSpellScriptData*>::*_383)(int) = &CExoArrayList<CNWSSpellScriptData*>::DelIndex;
CNWSSpellScriptData** (CExoArrayList<CNWSSpellScriptData*>::*_384)() = &CExoArrayList<CNWSSpellScriptData*>::begin;
CNWSSpellScriptData** (CExoArrayList<CNWSSpellScriptData*>::*_385)() = &CExoArrayList<CNWSSpellScriptData*>::end;
template CExoArrayList<CNWCCMessageData*>::CExoArrayList(int);
template CExoArrayList<CNWCCMessageData*>::CExoArrayList(const CExoArrayList<CNWCCMessageData*>&);
template CExoArrayList<CNWCCMessageData*>::~CExoArrayList() noexcept;
CExoArrayList<CNWCCMessageData*>& (CExoArrayList<CNWCCMessageData*>::*_386)(const CExoArrayList<CNWCCMessageData*>&) = &CExoArrayList<CNWCCMessageData*>::operator=;
CNWCCMessageData*& (CExoArrayList<CNWCCMessageData*>::*_387)(int) const = &CExoArrayList<CNWCCMessageData*>::operator[];
void (CExoArrayList<CNWCCMessageData*>::*_388)(int) = &CExoArrayList<CNWCCMessageData*>::Allocate;
void (CExoArrayList<CNWCCMessageData*>::*_389)(int) = &CExoArrayList<CNWCCMessageData*>::SetSize;
void (CExoArrayList<CNWCCMessageData*>::*_390)() = &CExoArrayList<CNWCCMessageData*>::Pack;
void (CExoArrayList<CNWCCMessageData*>::*_391)(CNWCCMessageData*) = &CExoArrayList<CNWCCMessageData*>::Add;
int (CExoArrayList<CNWCCMessageData*>::*_392)(CNWCCMessageData*) = &CExoArrayList<CNWCCMessageData*>::AddUnique;
int (CExoArrayList<CNWCCMessageData*>::*_393)(CNWCCMessageData*) = &CExoArrayList<CNWCCMessageData*>::Contains;
int (CExoArrayList<CNWCCMessageData*>::*_394)(CNWCCMessageData*) = &CExoArrayList<CNWCCMessageData*>::DerefContains;
void (CExoArrayList<CNWCCMessageData*>::*_395)(CNWCCMessageData*, int) = &CExoArrayList<CNWCCMessageData*>::Insert;
int (CExoArrayList<CNWCCMessageData*>::*_396)(CNWCCMessageData*) = &CExoArrayList<CNWCCMessageData*>::IndexOf;
void (CExoArrayList<CNWCCMessageData*>::*_397)(CNWCCMessageData*) = &CExoArrayList<CNWCCMessageData*>::Remove;
void (CExoArrayList<CNWCCMessageData*>::*_398)(int) = &CExoArrayList<CNWCCMessageData*>::DelIndex;
CNWCCMessageData** (CExoArrayList<CNWCCMessageData*>::*_399)() = &CExoArrayList<CNWCCMessageData*>::begin;
CNWCCMessageData** (CExoArrayList<CNWCCMessageData*>::*_400)() = &CExoArrayList<CNWCCMessageData*>::end;
template CExoArrayList<CNWVisibilityNode*>::CExoArrayList(int);
template CExoArrayList<CNWVisibilityNode*>::CExoArrayList(const CExoArrayList<CNWVisibilityNode*>&);
template CExoArrayList<CNWVisibilityNode*>::~CExoArrayList() noexcept;
CExoArrayList<CNWVisibilityNode*>& (CExoArrayList<CNWVisibilityNode*>::*_401)(const CExoArrayList<CNWVisibilityNode*>&) = &CExoArrayList<CNWVisibilityNode*>::operator=;
CNWVisibilityNode*& (CExoArrayList<CNWVisibilityNode*>::*_402)(int) const = &CExoArrayList<CNWVisibilityNode*>::operator[];
void (CExoArrayList<CNWVisibilityNode*>::*_403)(int) = &CExoArrayList<CNWVisibilityNode*>::Allocate;
void (CExoArrayList<CNWVisibilityNode*>::*_404)(int) = &CExoArrayList<CNWVisibilityNode*>::SetSize;
void (CExoArrayList<CNWVisibilityNode*>::*_405)() = &CExoArrayList<CNWVisibilityNode*>::Pack;
void (CExoArrayList<CNWVisibilityNode*>::*_406)(CNWVisibilityNode*) = &CExoArrayList<CNWVisibilityNode*>::Add;
int (CExoArrayList<CNWVisibilityNode*>::*_407)(CNWVisibilityNode*) = &CExoArrayList<CNWVisibilityNode*>::AddUnique;
int (CExoArrayList<CNWVisibilityNode*>::*_408)(CNWVisibilityNode*) = &CExoArrayList<CNWVisibilityNode*>::Contains;
int (CExoArrayList<CNWVisibilityNode*>::*_409)(CNWVisibilityNode*) = &CExoArrayList<CNWVisibilityNode*>::DerefContains;
void (CExoArrayList<CNWVisibilityNode*>::*_410)(CNWVisibilityNode*, int) = &CExoArrayList<CNWVisibilityNode*>::Insert;
int (CExoArrayList<CNWVisibilityNode*>::*_411)(CNWVisibilityNode*) = &CExoArrayList<CNWVisibilityNode*>::IndexOf;
void (CExoArrayList<CNWVisibilityNode*>::*_412)(CNWVisibilityNode*) = &CExoArrayList<CNWVisibilityNode*>::Remove;
void (CExoArrayList<CNWVisibilityNode*>::*_413)(int) = &CExoArrayList<CNWVisibilityNode*>::DelIndex;
CNWVisibilityNode** (CExoArrayList<CNWVisibilityNode*>::*_414)() = &CExoArrayList<CNWVisibilityNode*>::begin;
CNWVisibilityNode** (CExoArrayList<CNWVisibilityNode*>::*_415)() = &CExoArrayList<CNWVisibilityNode*>::end;
template CExoArrayList<CNWSPersonalReputation>::CExoArrayList(int);
template CExoArrayList<CNWSPersonalReputation>::CExoArrayList(const CExoArrayList<CNWSPersonalReputation>&);
template CExoArrayList<CNWSPersonalReputation>::~CExoArrayList() noexcept;
CExoArrayList<CNWSPersonalReputation>& (CExoArrayList<CNWSPersonalReputation>::*_416)(const CExoArrayList<CNWSPersonalReputation>&) = &CExoArrayList<CNWSPersonalReputation>::operator=;
CNWSPersonalReputation& (CExoArrayList<CNWSPersonalReputation>::*_417)(int) const = &CExoArrayList<CNWSPersonalReputation>::operator[];
void (CExoArrayList<CNWSPersonalReputation>::*_418)(int) = &CExoArrayList<CNWSPersonalReputation>::Allocate;
void (CExoArrayList<CNWSPersonalReputation>::*_419)(int) = &CExoArrayList<CNWSPersonalReputation>::SetSize;
void (CExoArrayList<CNWSPersonalReputation>::*_420)() = &CExoArrayList<CNWSPersonalReputation>::Pack;
void (CExoArrayList<CNWSPersonalReputation>::*_421)(CNWSPersonalReputation) = &CExoArrayList<CNWSPersonalReputation>::Add;
void (CExoArrayList<CNWSPersonalReputation>::*_422)(CNWSPersonalReputation, int) = &CExoArrayList<CNWSPersonalReputation>::Insert;
void (CExoArrayList<CNWSPersonalReputation>::*_423)(int) = &CExoArrayList<CNWSPersonalReputation>::DelIndex;
CNWSPersonalReputation* (CExoArrayList<CNWSPersonalReputation>::*_424)() = &CExoArrayList<CNWSPersonalReputation>::begin;
CNWSPersonalReputation* (CExoArrayList<CNWSPersonalReputation>::*_425)() = &CExoArrayList<CNWSPersonalReputation>::end;
template CExoArrayList<CFeatUseListEntry*>::CExoArrayList(int);
template CExoArrayList<CFeatUseListEntry*>::CExoArrayList(const CExoArrayList<CFeatUseListEntry*>&);
template CExoArrayList<CFeatUseListEntry*>::~CExoArrayList() noexcept;
CExoArrayList<CFeatUseListEntry*>& (CExoArrayList<CFeatUseListEntry*>::*_426)(const CExoArrayList<CFeatUseListEntry*>&) = &CExoArrayList<CFeatUseListEntry*>::operator=;
CFeatUseListEntry*& (CExoArrayList<CFeatUseListEntry*>::*_427)(int) const = &CExoArrayList<CFeatUseListEntry*>::operator[];
void (CExoArrayList<CFeatUseListEntry*>::*_428)(int) = &CExoArrayList<CFeatUseListEntry*>::Allocate;
void (CExoArrayList<CFeatUseListEntry*>::*_429)(int) = &CExoArrayList<CFeatUseListEntry*>::SetSize;
void (CExoArrayList<CFeatUseListEntry*>::*_430)() = &CExoArrayList<CFeatUseListEntry*>::Pack;
void (CExoArrayList<CFeatUseListEntry*>::*_431)(CFeatUseListEntry*) = &CExoArrayList<CFeatUseListEntry*>::Add;
int (CExoArrayList<CFeatUseListEntry*>::*_432)(CFeatUseListEntry*) = &CExoArrayList<CFeatUseListEntry*>::AddUnique;
int (CExoArrayList<CFeatUseListEntry*>::*_433)(CFeatUseListEntry*) = &CExoArrayList<CFeatUseListEntry*>::Contains;
int (CExoArrayList<CFeatUseListEntry*>::*_434)(CFeatUseListEntry*) = &CExoArrayList<CFeatUseListEntry*>::DerefContains;
void (CExoArrayList<CFeatUseListEntry*>::*_435)(CFeatUseListEntry*, int) = &CExoArrayList<CFeatUseListEntry*>::Insert;
int (CExoArrayList<CFeatUseListEntry*>::*_436)(CFeatUseListEntry*) = &CExoArrayList<CFeatUseListEntry*>::IndexOf;
void (CExoArrayList<CFeatUseListEntry*>::*_437)(CFeatUseListEntry*) = &CExoArrayList<CFeatUseListEntry*>::Remove;
void (CExoArrayList<CFeatUseListEntry*>::*_438)(int) = &CExoArrayList<CFeatUseListEntry*>::DelIndex;
CFeatUseListEntry** (CExoArrayList<CFeatUseListEntry*>::*_439)() = &CExoArrayList<CFeatUseListEntry*>::begin;
CFeatUseListEntry** (CExoArrayList<CFeatUseListEntry*>::*_440)() = &CExoArrayList<CFeatUseListEntry*>::end;
template CExoArrayList<CNWLevelStats*>::CExoArrayList(int);
template CExoArrayList<CNWLevelStats*>::CExoArrayList(const CExoArrayList<CNWLevelStats*>&);
template CExoArrayList<CNWLevelStats*>::~CExoArrayList() noexcept;
CExoArrayList<CNWLevelStats*>& (CExoArrayList<CNWLevelStats*>::*_441)(const CExoArrayList<CNWLevelStats*>&) = &CExoArrayList<CNWLevelStats*>::operator=;
CNWLevelStats*& (CExoArrayList<CNWLevelStats*>::*_442)(int) const = &CExoArrayList<CNWLevelStats*>::operator[];
void (CExoArrayList<CNWLevelStats*>::*_443)(int) = &CExoArrayList<CNWLevelStats*>::Allocate;
void (CExoArrayList<CNWLevelStats*>::*_444)(int) = &CExoArrayList<CNWLevelStats*>::SetSize;
void (CExoArrayList<CNWLevelStats*>::*_445)() = &CExoArrayList<CNWLevelStats*>::Pack;
void (CExoArrayList<CNWLevelStats*>::*_446)(CNWLevelStats*) = &CExoArrayList<CNWLevelStats*>::Add;
int (CExoArrayList<CNWLevelStats*>::*_447)(CNWLevelStats*) = &CExoArrayList<CNWLevelStats*>::AddUnique;
int (CExoArrayList<CNWLevelStats*>::*_448)(CNWLevelStats*) = &CExoArrayList<CNWLevelStats*>::Contains;
int (CExoArrayList<CNWLevelStats*>::*_449)(CNWLevelStats*) = &CExoArrayList<CNWLevelStats*>::DerefContains;
void (CExoArrayList<CNWLevelStats*>::*_450)(CNWLevelStats*, int) = &CExoArrayList<CNWLevelStats*>::Insert;
int (CExoArrayList<CNWLevelStats*>::*_451)(CNWLevelStats*) = &CExoArrayList<CNWLevelStats*>::IndexOf;
void (CExoArrayList<CNWLevelStats*>::*_452)(CNWLevelStats*) = &CExoArrayList<CNWLevelStats*>::Remove;
void (CExoArrayList<CNWLevelStats*>::*_453)(int) = &CExoArrayList<CNWLevelStats*>::DelIndex;
CNWLevelStats** (CExoArrayList<CNWLevelStats*>::*_454)() = &CExoArrayList<CNWLevelStats*>::begin;
CNWLevelStats** (CExoArrayList<CNWLevelStats*>::*_455)() = &CExoArrayList<CNWLevelStats*>::end;
template CExoArrayList<ScriptParam>::CExoArrayList(int);
template CExoArrayList<ScriptParam>::CExoArrayList(const CExoArrayList<ScriptParam>&);
template CExoArrayList<ScriptParam>::~CExoArrayList() noexcept;
CExoArrayList<ScriptParam>& (CExoArrayList<ScriptParam>::*_456)(const CExoArrayList<ScriptParam>&) = &CExoArrayList<ScriptParam>::operator=;
ScriptParam& (CExoArrayList<ScriptParam>::*_457)(int) const = &CExoArrayList<ScriptParam>::operator[];
void (CExoArrayList<ScriptParam>::*_458)(int) = &CExoArrayList<ScriptParam>::Allocate;
void (CExoArrayList<ScriptParam>::*_459)(int) = &CExoArrayList<ScriptParam>::SetSize;
void (CExoArrayList<ScriptParam>::*_460)() = &CExoArrayList<ScriptParam>::Pack;
void (CExoArrayList<ScriptParam>::*_461)(ScriptParam) = &CExoArrayList<ScriptParam>::Add;
void (CExoArrayList<ScriptParam>::*_462)(ScriptParam, int) = &CExoArrayList<ScriptParam>::Insert;
void (CExoArrayList<ScriptParam>::*_463)(int) = &CExoArrayList<ScriptParam>::DelIndex;
ScriptParam* (CExoArrayList<ScriptParam>::*_464)() = &CExoArrayList<ScriptParam>::begin;
ScriptParam* (CExoArrayList<ScriptParam>::*_465)() = &CExoArrayList<ScriptParam>::end;
template CExoArrayList<CNWItemProperty>::CExoArrayList(int);
template CExoArrayList<CNWItemProperty>::CExoArrayList(const CExoArrayList<CNWItemProperty>&);
template CExoArrayList<CNWItemProperty>::~CExoArrayList() noexcept;
CExoArrayList<CNWItemProperty>& (CExoArrayList<CNWItemProperty>::*_466)(const CExoArrayList<CNWItemProperty>&) = &CExoArrayList<CNWItemProperty>::operator=;
CNWItemProperty& (CExoArrayList<CNWItemProperty>::*_467)(int) const = &CExoArrayList<CNWItemProperty>::operator[];
void (CExoArrayList<CNWItemProperty>::*_468)(int) = &CExoArrayList<CNWItemProperty>::Allocate;
void (CExoArrayList<CNWItemProperty>::*_469)(int) = &CExoArrayList<CNWItemProperty>::SetSize;
void (CExoArrayList<CNWItemProperty>::*_470)() = &CExoArrayList<CNWItemProperty>::Pack;
void (CExoArrayList<CNWItemProperty>::*_471)(CNWItemProperty) = &CExoArrayList<CNWItemProperty>::Add;
void (CExoArrayList<CNWItemProperty>::*_472)(CNWItemProperty, int) = &CExoArrayList<CNWItemProperty>::Insert;
void (CExoArrayList<CNWItemProperty>::*_473)(int) = &CExoArrayList<CNWItemProperty>::DelIndex;
CNWItemProperty* (CExoArrayList<CNWItemProperty>::*_474)() = &CExoArrayList<CNWItemProperty>::begin;
CNWItemProperty* (CExoArrayList<CNWItemProperty>::*_475)() = &CExoArrayList<CNWItemProperty>::end;
template CExoArrayList<SJournalEntry>::CExoArrayList(int);
template CExoArrayList<SJournalEntry>::CExoArrayList(const CExoArrayList<SJournalEntry>&);
template CExoArrayList<SJournalEntry>::~CExoArrayList() noexcept;
CExoArrayList<SJournalEntry>& (CExoArrayList<SJournalEntry>::*_476)(const CExoArrayList<SJournalEntry>&) = &CExoArrayList<SJournalEntry>::operator=;
SJournalEntry& (CExoArrayList<SJournalEntry>::*_477)(int) const = &CExoArrayList<SJournalEntry>::operator[];
void (CExoArrayList<SJournalEntry>::*_478)(int) = &CExoArrayList<SJournalEntry>::Allocate;
void (CExoArrayList<SJournalEntry>::*_479)(int) = &CExoArrayList<SJournalEntry>::SetSize;
void (CExoArrayList<SJournalEntry>::*_480)() = &CExoArrayList<SJournalEntry>::Pack;
void (CExoArrayList<SJournalEntry>::*_481)(SJournalEntry) = &CExoArrayList<SJournalEntry>::Add;
void (CExoArrayList<SJournalEntry>::*_482)(SJournalEntry, int) = &CExoArrayList<SJournalEntry>::Insert;
void (CExoArrayList<SJournalEntry>::*_483)(int) = &CExoArrayList<SJournalEntry>::DelIndex;
SJournalEntry* (CExoArrayList<SJournalEntry>::*_484)() = &CExoArrayList<SJournalEntry>::begin;
SJournalEntry* (CExoArrayList<SJournalEntry>::*_485)() = &CExoArrayList<SJournalEntry>::end;
template CExoArrayList<CNWSTagNode>::CExoArrayList(int);
template CExoArrayList<CNWSTagNode>::CExoArrayList(const CExoArrayList<CNWSTagNode>&);
template CExoArrayList<CNWSTagNode>::~CExoArrayList() noexcept;
CExoArrayList<CNWSTagNode>& (CExoArrayList<CNWSTagNode>::*_486)(const CExoArrayList<CNWSTagNode>&) = &CExoArrayList<CNWSTagNode>::operator=;
CNWSTagNode& (CExoArrayList<CNWSTagNode>::*_487)(int) const = &CExoArrayList<CNWSTagNode>::operator[];
void (CExoArrayList<CNWSTagNode>::*_488)(int) = &CExoArrayList<CNWSTagNode>::Allocate;
void (CExoArrayList<CNWSTagNode>::*_489)(int) = &CExoArrayList<CNWSTagNode>::SetSize;
void (CExoArrayList<CNWSTagNode>::*_490)() = &CExoArrayList<CNWSTagNode>::Pack;
void (CExoArrayList<CNWSTagNode>::*_491)(CNWSTagNode) = &CExoArrayList<CNWSTagNode>::Add;
void (CExoArrayList<CNWSTagNode>::*_492)(CNWSTagNode, int) = &CExoArrayList<CNWSTagNode>::Insert;
void (CExoArrayList<CNWSTagNode>::*_493)(int) = &CExoArrayList<CNWSTagNode>::DelIndex;
CNWSTagNode* (CExoArrayList<CNWSTagNode>::*_494)() = &CExoArrayList<CNWSTagNode>::begin;
CNWSTagNode* (CExoArrayList<CNWSTagNode>::*_495)() = &CExoArrayList<CNWSTagNode>::end;
template CExoArrayList<CWorldJournalEntry>::CExoArrayList(int);
template CExoArrayList<CWorldJournalEntry>::CExoArrayList(const CExoArrayList<CWorldJournalEntry>&);
template CExoArrayList<CWorldJournalEntry>::~CExoArrayList() noexcept;
CExoArrayList<CWorldJournalEntry>& (CExoArrayList<CWorldJournalEntry>::*_496)(const CExoArrayList<CWorldJournalEntry>&) = &CExoArrayList<CWorldJournalEntry>::operator=;
CWorldJournalEntry& (CExoArrayList<CWorldJournalEntry>::*_497)(int) const = &CExoArrayList<CWorldJournalEntry>::operator[];
void (CExoArrayList<CWorldJournalEntry>::*_498)(int) = &CExoArrayList<CWorldJournalEntry>::Allocate;
void (CExoArrayList<CWorldJournalEntry>::*_499)(int) = &CExoArrayList<CWorldJournalEntry>::SetSize;
void (CExoArrayList<CWorldJournalEntry>::*_500)() = &CExoArrayList<CWorldJournalEntry>::Pack;
void (CExoArrayList<CWorldJournalEntry>::*_501)(CWorldJournalEntry) = &CExoArrayList<CWorldJournalEntry>::Add;
void (CExoArrayList<CWorldJournalEntry>::*_502)(CWorldJournalEntry, int) = &CExoArrayList<CWorldJournalEntry>::Insert;
void (CExoArrayList<CWorldJournalEntry>::*_503)(int) = &CExoArrayList<CWorldJournalEntry>::DelIndex;
CWorldJournalEntry* (CExoArrayList<CWorldJournalEntry>::*_504)() = &CExoArrayList<CWorldJournalEntry>::begin;
CWorldJournalEntry* (CExoArrayList<CWorldJournalEntry>::*_505)() = &CExoArrayList<CWorldJournalEntry>::end;
template CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::CExoArrayList(int);
template CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::CExoArrayList(const CExoArrayList<NWPLAYERCHARACTERLISTITEM*>&);
template CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::~CExoArrayList() noexcept;
CExoArrayList<NWPLAYERCHARACTERLISTITEM*>& (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_506)(const CExoArrayList<NWPLAYERCHARACTERLISTITEM*>&) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::operator=;
NWPLAYERCHARACTERLISTITEM*& (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_507)(int) const = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::operator[];
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_508)(int) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::Allocate;
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_509)(int) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::SetSize;
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_510)() = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::Pack;
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_511)(NWPLAYERCHARACTERLISTITEM*) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::Add;
int (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_512)(NWPLAYERCHARACTERLISTITEM*) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::AddUnique;
int (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_513)(NWPLAYERCHARACTERLISTITEM*) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::Contains;
int (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_514)(NWPLAYERCHARACTERLISTITEM*) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::DerefContains;
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_515)(NWPLAYERCHARACTERLISTITEM*, int) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::Insert;
int (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_516)(NWPLAYERCHARACTERLISTITEM*) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::IndexOf;
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_517)(NWPLAYERCHARACTERLISTITEM*) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::Remove;
void (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_518)(int) = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::DelIndex;
NWPLAYERCHARACTERLISTITEM** (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_519)() = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::begin;
NWPLAYERCHARACTERLISTITEM** (CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::*_520)() = &CExoArrayList<NWPLAYERCHARACTERLISTITEM*>::end;
template CExoArrayList<CNWSPlayerJournalQuestUpdates>::CExoArrayList(int);
template CExoArrayList<CNWSPlayerJournalQuestUpdates>::CExoArrayList(const CExoArrayList<CNWSPlayerJournalQuestUpdates>&);
template CExoArrayList<CNWSPlayerJournalQuestUpdates>::~CExoArrayList() noexcept;
CExoArrayList<CNWSPlayerJournalQuestUpdates>& (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_521)(const CExoArrayList<CNWSPlayerJournalQuestUpdates>&) = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::operator=;
CNWSPlayerJournalQuestUpdates& (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_522)(int) const = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::operator[];
void (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_523)(int) = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::Allocate;
void (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_524)(int) = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::SetSize;
void (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_525)() = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::Pack;
void (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_526)(CNWSPlayerJournalQuestUpdates) = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::Add;
void (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_527)(CNWSPlayerJournalQuestUpdates, int) = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::Insert;
void (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_528)(int) = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::DelIndex;
CNWSPlayerJournalQuestUpdates* (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_529)() = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::begin;
CNWSPlayerJournalQuestUpdates* (CExoArrayList<CNWSPlayerJournalQuestUpdates>::*_530)() = &CExoArrayList<CNWSPlayerJournalQuestUpdates>::end;
template CExoArrayList<CResRef>::CExoArrayList(int);
template CExoArrayList<CResRef>::CExoArrayList(const CExoArrayList<CResRef>&);
template CExoArrayList<CResRef>::~CExoArrayList() noexcept;
CExoArrayList<CResRef>& (CExoArrayList<CResRef>::*_531)(const CExoArrayList<CResRef>&) = &CExoArrayList<CResRef>::operator=;
CResRef& (CExoArrayList<CResRef>::*_532)(int) const = &CExoArrayList<CResRef>::operator[];
void (CExoArrayList<CResRef>::*_533)(int) = &CExoArrayList<CResRef>::Allocate;
void (CExoArrayList<CResRef>::*_534)(int) = &CExoArrayList<CResRef>::SetSize;
void (CExoArrayList<CResRef>::*_535)() = &CExoArrayList<CResRef>::Pack;
void (CExoArrayList<CResRef>::*_536)(CResRef) = &CExoArrayList<CResRef>::Add;
int (CExoArrayList<CResRef>::*_537)(CResRef) = &CExoArrayList<CResRef>::AddUnique;
int (CExoArrayList<CResRef>::*_538)(CResRef) = &CExoArrayList<CResRef>::Contains;
void (CExoArrayList<CResRef>::*_539)(CResRef, int) = &CExoArrayList<CResRef>::Insert;
int (CExoArrayList<CResRef>::*_540)(CResRef) = &CExoArrayList<CResRef>::IndexOf;
void (CExoArrayList<CResRef>::*_541)(CResRef) = &CExoArrayList<CResRef>::Remove;
void (CExoArrayList<CResRef>::*_542)(int) = &CExoArrayList<CResRef>::DelIndex;
CResRef* (CExoArrayList<CResRef>::*_543)() = &CExoArrayList<CResRef>::begin;
CResRef* (CExoArrayList<CResRef>::*_544)() = &CExoArrayList<CResRef>::end;
template CExoArrayList<CStoreCustomer*>::CExoArrayList(int);
template CExoArrayList<CStoreCustomer*>::CExoArrayList(const CExoArrayList<CStoreCustomer*>&);
template CExoArrayList<CStoreCustomer*>::~CExoArrayList() noexcept;
CExoArrayList<CStoreCustomer*>& (CExoArrayList<CStoreCustomer*>::*_545)(const CExoArrayList<CStoreCustomer*>&) = &CExoArrayList<CStoreCustomer*>::operator=;
CStoreCustomer*& (CExoArrayList<CStoreCustomer*>::*_546)(int) const = &CExoArrayList<CStoreCustomer*>::operator[];
void (CExoArrayList<CStoreCustomer*>::*_547)(int) = &CExoArrayList<CStoreCustomer*>::Allocate;
void (CExoArrayList<CStoreCustomer*>::*_548)(int) = &CExoArrayList<CStoreCustomer*>::SetSize;
void (CExoArrayList<CStoreCustomer*>::*_549)() = &CExoArrayList<CStoreCustomer*>::Pack;
void (CExoArrayList<CStoreCustomer*>::*_550)(CStoreCustomer*) = &CExoArrayList<CStoreCustomer*>::Add;
int (CExoArrayList<CStoreCustomer*>::*_551)(CStoreCustomer*) = &CExoArrayList<CStoreCustomer*>::AddUnique;
int (CExoArrayList<CStoreCustomer*>::*_552)(CStoreCustomer*) = &CExoArrayList<CStoreCustomer*>::Contains;
int (CExoArrayList<CStoreCustomer*>::*_553)(CStoreCustomer*) = &CExoArrayList<CStoreCustomer*>::DerefContains;
void (CExoArrayList<CStoreCustomer*>::*_554)(CStoreCustomer*, int) = &CExoArrayList<CStoreCustomer*>::Insert;
int (CExoArrayList<CStoreCustomer*>::*_555)(CStoreCustomer*) = &CExoArrayList<CStoreCustomer*>::IndexOf;
void (CExoArrayList<CStoreCustomer*>::*_556)(CStoreCustomer*) = &CExoArrayList<CStoreCustomer*>::Remove;
void (CExoArrayList<CStoreCustomer*>::*_557)(int) = &CExoArrayList<CStoreCustomer*>::DelIndex;
CStoreCustomer** (CExoArrayList<CStoreCustomer*>::*_558)() = &CExoArrayList<CStoreCustomer*>::begin;
CStoreCustomer** (CExoArrayList<CStoreCustomer*>::*_559)() = &CExoArrayList<CStoreCustomer*>::end;
template CExoArrayList<SSubNetProfile*>::CExoArrayList(int);
template CExoArrayList<SSubNetProfile*>::CExoArrayList(const CExoArrayList<SSubNetProfile*>&);
template CExoArrayList<SSubNetProfile*>::~CExoArrayList() noexcept;
CExoArrayList<SSubNetProfile*>& (CExoArrayList<SSubNetProfile*>::*_560)(const CExoArrayList<SSubNetProfile*>&) = &CExoArrayList<SSubNetProfile*>::operator=;
SSubNetProfile*& (CExoArrayList<SSubNetProfile*>::*_561)(int) const = &CExoArrayList<SSubNetProfile*>::operator[];
void (CExoArrayList<SSubNetProfile*>::*_562)(int) = &CExoArrayList<SSubNetProfile*>::Allocate;
void (CExoArrayList<SSubNetProfile*>::*_563)(int) = &CExoArrayList<SSubNetProfile*>::SetSize;
void (CExoArrayList<SSubNetProfile*>::*_564)() = &CExoArrayList<SSubNetProfile*>::Pack;
void (CExoArrayList<SSubNetProfile*>::*_565)(SSubNetProfile*) = &CExoArrayList<SSubNetProfile*>::Add;
int (CExoArrayList<SSubNetProfile*>::*_566)(SSubNetProfile*) = &CExoArrayList<SSubNetProfile*>::AddUnique;
int (CExoArrayList<SSubNetProfile*>::*_567)(SSubNetProfile*) = &CExoArrayList<SSubNetProfile*>::Contains;
int (CExoArrayList<SSubNetProfile*>::*_568)(SSubNetProfile*) = &CExoArrayList<SSubNetProfile*>::DerefContains;
void (CExoArrayList<SSubNetProfile*>::*_569)(SSubNetProfile*, int) = &CExoArrayList<SSubNetProfile*>::Insert;
int (CExoArrayList<SSubNetProfile*>::*_570)(SSubNetProfile*) = &CExoArrayList<SSubNetProfile*>::IndexOf;
void (CExoArrayList<SSubNetProfile*>::*_571)(SSubNetProfile*) = &CExoArrayList<SSubNetProfile*>::Remove;
void (CExoArrayList<SSubNetProfile*>::*_572)(int) = &CExoArrayList<SSubNetProfile*>::DelIndex;
SSubNetProfile** (CExoArrayList<SSubNetProfile*>::*_573)() = &CExoArrayList<SSubNetProfile*>::begin;
SSubNetProfile** (CExoArrayList<SSubNetProfile*>::*_574)() = &CExoArrayList<SSubNetProfile*>::end;
template CExoArrayList<CScriptLog*>::CExoArrayList(int);
template CExoArrayList<CScriptLog*>::CExoArrayList(const CExoArrayList<CScriptLog*>&);
template CExoArrayList<CScriptLog*>::~CExoArrayList() noexcept;
CExoArrayList<CScriptLog*>& (CExoArrayList<CScriptLog*>::*_575)(const CExoArrayList<CScriptLog*>&) = &CExoArrayList<CScriptLog*>::operator=;
CScriptLog*& (CExoArrayList<CScriptLog*>::*_576)(int) const = &CExoArrayList<CScriptLog*>::operator[];
void (CExoArrayList<CScriptLog*>::*_577)(int) = &CExoArrayList<CScriptLog*>::Allocate;
void (CExoArrayList<CScriptLog*>::*_578)(int) = &CExoArrayList<CScriptLog*>::SetSize;
void (CExoArrayList<CScriptLog*>::*_579)() = &CExoArrayList<CScriptLog*>::Pack;
void (CExoArrayList<CScriptLog*>::*_580)(CScriptLog*) = &CExoArrayList<CScriptLog*>::Add;
int (CExoArrayList<CScriptLog*>::*_581)(CScriptLog*) = &CExoArrayList<CScriptLog*>::AddUnique;
int (CExoArrayList<CScriptLog*>::*_582)(CScriptLog*) = &CExoArrayList<CScriptLog*>::Contains;
int (CExoArrayList<CScriptLog*>::*_583)(CScriptLog*) = &CExoArrayList<CScriptLog*>::DerefContains;
void (CExoArrayList<CScriptLog*>::*_584)(CScriptLog*, int) = &CExoArrayList<CScriptLog*>::Insert;
int (CExoArrayList<CScriptLog*>::*_585)(CScriptLog*) = &CExoArrayList<CScriptLog*>::IndexOf;
void (CExoArrayList<CScriptLog*>::*_586)(CScriptLog*) = &CExoArrayList<CScriptLog*>::Remove;
void (CExoArrayList<CScriptLog*>::*_587)(int) = &CExoArrayList<CScriptLog*>::DelIndex;
CScriptLog** (CExoArrayList<CScriptLog*>::*_588)() = &CExoArrayList<CScriptLog*>::begin;
CScriptLog** (CExoArrayList<CScriptLog*>::*_589)() = &CExoArrayList<CScriptLog*>::end;
template CExoArrayList<NWPlayerCharacterListClass_st>::CExoArrayList(int);
template CExoArrayList<NWPlayerCharacterListClass_st>::CExoArrayList(const CExoArrayList<NWPlayerCharacterListClass_st>&);
template CExoArrayList<NWPlayerCharacterListClass_st>::~CExoArrayList() noexcept;
CExoArrayList<NWPlayerCharacterListClass_st>& (CExoArrayList<NWPlayerCharacterListClass_st>::*_590)(const CExoArrayList<NWPlayerCharacterListClass_st>&) = &CExoArrayList<NWPlayerCharacterListClass_st>::operator=;
NWPlayerCharacterListClass_st& (CExoArrayList<NWPlayerCharacterListClass_st>::*_591)(int) const = &CExoArrayList<NWPlayerCharacterListClass_st>::operator[];
void (CExoArrayList<NWPlayerCharacterListClass_st>::*_592)(int) = &CExoArrayList<NWPlayerCharacterListClass_st>::Allocate;
void (CExoArrayList<NWPlayerCharacterListClass_st>::*_593)(int) = &CExoArrayList<NWPlayerCharacterListClass_st>::SetSize;
void (CExoArrayList<NWPlayerCharacterListClass_st>::*_594)() = &CExoArrayList<NWPlayerCharacterListClass_st>::Pack;
void (CExoArrayList<NWPlayerCharacterListClass_st>::*_595)(NWPlayerCharacterListClass_st) = &CExoArrayList<NWPlayerCharacterListClass_st>::Add;
void (CExoArrayList<NWPlayerCharacterListClass_st>::*_596)(NWPlayerCharacterListClass_st, int) = &CExoArrayList<NWPlayerCharacterListClass_st>::Insert;
void (CExoArrayList<NWPlayerCharacterListClass_st>::*_597)(int) = &CExoArrayList<NWPlayerCharacterListClass_st>::DelIndex;
NWPlayerCharacterListClass_st* (CExoArrayList<NWPlayerCharacterListClass_st>::*_598)() = &CExoArrayList<NWPlayerCharacterListClass_st>::begin;
NWPlayerCharacterListClass_st* (CExoArrayList<NWPlayerCharacterListClass_st>::*_599)() = &CExoArrayList<NWPlayerCharacterListClass_st>::end;
extern "C" { void CCallbackHandlerBase_CCallbackHandlerBase(void* __instance) { ::new (__instance) CCallbackHandlerBase(); } }
extern "C" { void CCallbackHandlerBase_CCallbackHandlerBase___1__S_CCallbackHandlerBase(void* __instance, const CCallbackHandlerBase& _0) { ::new (__instance) CCallbackHandlerBase(_0); } }
CCallbackHandlerBase& (CCallbackHandlerBase::*_600)(CCallbackHandlerBase&&) = &CCallbackHandlerBase::operator=;
extern "C" { void CCombatInformation_CCombatInformation___1__S_CCombatInformation(void* __instance, const CCombatInformation& _0) { ::new (__instance) CCombatInformation(_0); } }
extern "C" { void CCombatInformationNode_CCombatInformationNode___1__S_CCombatInformationNode(void* __instance, const CCombatInformationNode& _0) { ::new (__instance) CCombatInformationNode(_0); } }
extern "C" { void CEffectIconObject_CEffectIconObject(void* __instance) { ::new (__instance) CEffectIconObject(); } }
extern "C" { void CEffectIconObject_CEffectIconObject___1__S_CEffectIconObject(void* __instance, const CEffectIconObject& _0) { ::new (__instance) CEffectIconObject(_0); } }
CEffectIconObject& (CEffectIconObject::*_601)(CEffectIconObject&&) = &CEffectIconObject::operator=;
CEncounterListEntry& (CEncounterListEntry::*_602)(CEncounterListEntry&&) = &CEncounterListEntry::operator=;
extern "C" { void CEncounterListEntry_CEncounterListEntry(void* __instance) { ::new (__instance) CEncounterListEntry(); } }
extern "C" { void CEncounterListEntry_CEncounterListEntry___1__S_CEncounterListEntry(void* __instance, const CEncounterListEntry& _0) { ::new (__instance) CEncounterListEntry(_0); } }
extern "C" { void CEncounterSpawnPoint_CEncounterSpawnPoint(void* __instance) { ::new (__instance) CEncounterSpawnPoint(); } }
extern "C" { void CEncounterSpawnPoint_CEncounterSpawnPoint___1__S_CEncounterSpawnPoint(void* __instance, const CEncounterSpawnPoint& _0) { ::new (__instance) CEncounterSpawnPoint(_0); } }
CEncounterSpawnPoint& (CEncounterSpawnPoint::*_603)(CEncounterSpawnPoint&&) = &CEncounterSpawnPoint::operator=;
extern "C" { void CERFFile_CERFFile___1__S_CERFFile(void* __instance, const CERFFile& _0) { ::new (__instance) CERFFile(_0); } }
CERFFile& (CERFFile::*_604)(const CERFFile&) = &CERFFile::operator=;
extern "C" { void CERFKey_CERFKey___1__S_CERFKey(void* __instance, const CERFKey& _0) { ::new (__instance) CERFKey(_0); } }
CERFKey& (CERFKey::*_605)(const CERFKey&) = &CERFKey::operator=;
extern "C" { void CERFRes_CERFRes___1__S_CERFRes(void* __instance, const CERFRes& _0) { ::new (__instance) CERFRes(_0); } }
CERFRes& (CERFRes::*_606)(const CERFRes&) = &CERFRes::operator=;
extern "C" { void CERFString_CERFString___1__S_CERFString(void* __instance, const CERFString& _0) { ::new (__instance) CERFString(_0); } }
CERFString& (CERFString::*_607)(const CERFString&) = &CERFString::operator=;
extern "C" { void CExoLinkedListInternal_CExoLinkedListInternal(void* __instance) { ::new (__instance) CExoLinkedListInternal(); } }
extern "C" { void CExoLinkedListInternal_CExoLinkedListInternal___1__S_CExoLinkedListInternal(void* __instance, const CExoLinkedListInternal& _0) { ::new (__instance) CExoLinkedListInternal(_0); } }
CExoLinkedListInternal& (CExoLinkedListInternal::*_608)(const CExoLinkedListInternal&) = &CExoLinkedListInternal::operator=;
extern "C" { void CExoLinkedListNode_CExoLinkedListNode(void* __instance) { ::new (__instance) CExoLinkedListNode(); } }
extern "C" { void CExoLinkedListNode_CExoLinkedListNode___1__S_CExoLinkedListNode(void* __instance, const CExoLinkedListNode& _0) { ::new (__instance) CExoLinkedListNode(_0); } }
CExoLinkedListNode& (CExoLinkedListNode::*_609)(CExoLinkedListNode&&) = &CExoLinkedListNode::operator=;
template CExoLinkedList<CERFString>::CExoLinkedList();
template CExoLinkedList<CERFString>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CERFString>::*_610)(CERFString*) = &CExoLinkedList<CERFString>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CERFString>::*_611)(CERFString*) = &CExoLinkedList<CERFString>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CERFString>::*_612)(CERFString*, CExoLinkedListNode*) = &CExoLinkedList<CERFString>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CERFString>::*_613)(CERFString*, CExoLinkedListNode*) = &CExoLinkedList<CERFString>::AddBefore;
unsigned int (CExoLinkedList<CERFString>::*_614)() = &CExoLinkedList<CERFString>::Count;
CERFString* (CExoLinkedList<CERFString>::*_615)(CExoLinkedListNode*) = &CExoLinkedList<CERFString>::GetAtPos;
CERFString* (CExoLinkedList<CERFString>::*_616)() = &CExoLinkedList<CERFString>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CERFString>::*_617)() = &CExoLinkedList<CERFString>::GetHeadPos;
CERFString* (CExoLinkedList<CERFString>::*_618)(CExoLinkedListNode*&) = &CExoLinkedList<CERFString>::GetNext;
CERFString* (CExoLinkedList<CERFString>::*_619)(CExoLinkedListNode*&) = &CExoLinkedList<CERFString>::GetPrev;
CERFString* (CExoLinkedList<CERFString>::*_620)() = &CExoLinkedList<CERFString>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CERFString>::*_621)() = &CExoLinkedList<CERFString>::GetTailPos;
int (CExoLinkedList<CERFString>::*_622)() = &CExoLinkedList<CERFString>::IsEmpty;
CERFString* (CExoLinkedList<CERFString>::*_623)() = &CExoLinkedList<CERFString>::RemoveHead;
CERFString* (CExoLinkedList<CERFString>::*_624)() = &CExoLinkedList<CERFString>::RemoveTail;
CERFString* (CExoLinkedList<CERFString>::*_625)(CExoLinkedListNode*) = &CExoLinkedList<CERFString>::Remove;
extern "C" { void CExoLinkedList____S_CERFString_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CERFString>& _0) { ::new (__instance) CExoLinkedList<CERFString>(_0); } }
CExoLinkedList<CERFString>& (CExoLinkedList<CERFString>::*_626)(const CExoLinkedList<CERFString>&) = &CExoLinkedList<CERFString>::operator=;
template CExoLinkedList<CERFKey>::CExoLinkedList();
template CExoLinkedList<CERFKey>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CERFKey>::*_627)(CERFKey*) = &CExoLinkedList<CERFKey>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CERFKey>::*_628)(CERFKey*) = &CExoLinkedList<CERFKey>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CERFKey>::*_629)(CERFKey*, CExoLinkedListNode*) = &CExoLinkedList<CERFKey>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CERFKey>::*_630)(CERFKey*, CExoLinkedListNode*) = &CExoLinkedList<CERFKey>::AddBefore;
unsigned int (CExoLinkedList<CERFKey>::*_631)() = &CExoLinkedList<CERFKey>::Count;
CERFKey* (CExoLinkedList<CERFKey>::*_632)(CExoLinkedListNode*) = &CExoLinkedList<CERFKey>::GetAtPos;
CERFKey* (CExoLinkedList<CERFKey>::*_633)() = &CExoLinkedList<CERFKey>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CERFKey>::*_634)() = &CExoLinkedList<CERFKey>::GetHeadPos;
CERFKey* (CExoLinkedList<CERFKey>::*_635)(CExoLinkedListNode*&) = &CExoLinkedList<CERFKey>::GetNext;
CERFKey* (CExoLinkedList<CERFKey>::*_636)(CExoLinkedListNode*&) = &CExoLinkedList<CERFKey>::GetPrev;
CERFKey* (CExoLinkedList<CERFKey>::*_637)() = &CExoLinkedList<CERFKey>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CERFKey>::*_638)() = &CExoLinkedList<CERFKey>::GetTailPos;
int (CExoLinkedList<CERFKey>::*_639)() = &CExoLinkedList<CERFKey>::IsEmpty;
CERFKey* (CExoLinkedList<CERFKey>::*_640)() = &CExoLinkedList<CERFKey>::RemoveHead;
CERFKey* (CExoLinkedList<CERFKey>::*_641)() = &CExoLinkedList<CERFKey>::RemoveTail;
CERFKey* (CExoLinkedList<CERFKey>::*_642)(CExoLinkedListNode*) = &CExoLinkedList<CERFKey>::Remove;
extern "C" { void CExoLinkedList____S_CERFKey_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CERFKey>& _0) { ::new (__instance) CExoLinkedList<CERFKey>(_0); } }
CExoLinkedList<CERFKey>& (CExoLinkedList<CERFKey>::*_643)(const CExoLinkedList<CERFKey>&) = &CExoLinkedList<CERFKey>::operator=;
template CExoLinkedList<CERFRes>::CExoLinkedList();
template CExoLinkedList<CERFRes>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CERFRes>::*_644)(CERFRes*) = &CExoLinkedList<CERFRes>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CERFRes>::*_645)(CERFRes*) = &CExoLinkedList<CERFRes>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CERFRes>::*_646)(CERFRes*, CExoLinkedListNode*) = &CExoLinkedList<CERFRes>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CERFRes>::*_647)(CERFRes*, CExoLinkedListNode*) = &CExoLinkedList<CERFRes>::AddBefore;
unsigned int (CExoLinkedList<CERFRes>::*_648)() = &CExoLinkedList<CERFRes>::Count;
CERFRes* (CExoLinkedList<CERFRes>::*_649)(CExoLinkedListNode*) = &CExoLinkedList<CERFRes>::GetAtPos;
CERFRes* (CExoLinkedList<CERFRes>::*_650)() = &CExoLinkedList<CERFRes>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CERFRes>::*_651)() = &CExoLinkedList<CERFRes>::GetHeadPos;
CERFRes* (CExoLinkedList<CERFRes>::*_652)(CExoLinkedListNode*&) = &CExoLinkedList<CERFRes>::GetNext;
CERFRes* (CExoLinkedList<CERFRes>::*_653)(CExoLinkedListNode*&) = &CExoLinkedList<CERFRes>::GetPrev;
CERFRes* (CExoLinkedList<CERFRes>::*_654)() = &CExoLinkedList<CERFRes>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CERFRes>::*_655)() = &CExoLinkedList<CERFRes>::GetTailPos;
int (CExoLinkedList<CERFRes>::*_656)() = &CExoLinkedList<CERFRes>::IsEmpty;
CERFRes* (CExoLinkedList<CERFRes>::*_657)() = &CExoLinkedList<CERFRes>::RemoveHead;
CERFRes* (CExoLinkedList<CERFRes>::*_658)() = &CExoLinkedList<CERFRes>::RemoveTail;
CERFRes* (CExoLinkedList<CERFRes>::*_659)(CExoLinkedListNode*) = &CExoLinkedList<CERFRes>::Remove;
extern "C" { void CExoLinkedList____S_CERFRes_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CERFRes>& _0) { ::new (__instance) CExoLinkedList<CERFRes>(_0); } }
CExoLinkedList<CERFRes>& (CExoLinkedList<CERFRes>::*_660)(const CExoLinkedList<CERFRes>&) = &CExoLinkedList<CERFRes>::operator=;
template CExoLinkedList<CKeyTableInfo>::CExoLinkedList();
template CExoLinkedList<CKeyTableInfo>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CKeyTableInfo>::*_661)(CKeyTableInfo*) = &CExoLinkedList<CKeyTableInfo>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CKeyTableInfo>::*_662)(CKeyTableInfo*) = &CExoLinkedList<CKeyTableInfo>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CKeyTableInfo>::*_663)(CKeyTableInfo*, CExoLinkedListNode*) = &CExoLinkedList<CKeyTableInfo>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CKeyTableInfo>::*_664)(CKeyTableInfo*, CExoLinkedListNode*) = &CExoLinkedList<CKeyTableInfo>::AddBefore;
unsigned int (CExoLinkedList<CKeyTableInfo>::*_665)() = &CExoLinkedList<CKeyTableInfo>::Count;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_666)(CExoLinkedListNode*) = &CExoLinkedList<CKeyTableInfo>::GetAtPos;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_667)() = &CExoLinkedList<CKeyTableInfo>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CKeyTableInfo>::*_668)() = &CExoLinkedList<CKeyTableInfo>::GetHeadPos;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_669)(CExoLinkedListNode*&) = &CExoLinkedList<CKeyTableInfo>::GetNext;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_670)(CExoLinkedListNode*&) = &CExoLinkedList<CKeyTableInfo>::GetPrev;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_671)() = &CExoLinkedList<CKeyTableInfo>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CKeyTableInfo>::*_672)() = &CExoLinkedList<CKeyTableInfo>::GetTailPos;
int (CExoLinkedList<CKeyTableInfo>::*_673)() = &CExoLinkedList<CKeyTableInfo>::IsEmpty;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_674)() = &CExoLinkedList<CKeyTableInfo>::RemoveHead;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_675)() = &CExoLinkedList<CKeyTableInfo>::RemoveTail;
CKeyTableInfo* (CExoLinkedList<CKeyTableInfo>::*_676)(CExoLinkedListNode*) = &CExoLinkedList<CKeyTableInfo>::Remove;
extern "C" { void CExoLinkedList____S_CKeyTableInfo_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CKeyTableInfo>& _0) { ::new (__instance) CExoLinkedList<CKeyTableInfo>(_0); } }
CExoLinkedList<CKeyTableInfo>& (CExoLinkedList<CKeyTableInfo>::*_677)(const CExoLinkedList<CKeyTableInfo>&) = &CExoLinkedList<CKeyTableInfo>::operator=;
template CExoLinkedList<EXOLOCSTRING>::CExoLinkedList();
template CExoLinkedList<EXOLOCSTRING>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<EXOLOCSTRING>::*_678)(EXOLOCSTRING*) = &CExoLinkedList<EXOLOCSTRING>::AddHead;
CExoLinkedListNode* (CExoLinkedList<EXOLOCSTRING>::*_679)(EXOLOCSTRING*) = &CExoLinkedList<EXOLOCSTRING>::AddTail;
CExoLinkedListNode* (CExoLinkedList<EXOLOCSTRING>::*_680)(EXOLOCSTRING*, CExoLinkedListNode*) = &CExoLinkedList<EXOLOCSTRING>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<EXOLOCSTRING>::*_681)(EXOLOCSTRING*, CExoLinkedListNode*) = &CExoLinkedList<EXOLOCSTRING>::AddBefore;
unsigned int (CExoLinkedList<EXOLOCSTRING>::*_682)() = &CExoLinkedList<EXOLOCSTRING>::Count;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_683)(CExoLinkedListNode*) = &CExoLinkedList<EXOLOCSTRING>::GetAtPos;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_684)() = &CExoLinkedList<EXOLOCSTRING>::GetHead;
CExoLinkedListNode* (CExoLinkedList<EXOLOCSTRING>::*_685)() = &CExoLinkedList<EXOLOCSTRING>::GetHeadPos;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_686)(CExoLinkedListNode*&) = &CExoLinkedList<EXOLOCSTRING>::GetNext;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_687)(CExoLinkedListNode*&) = &CExoLinkedList<EXOLOCSTRING>::GetPrev;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_688)() = &CExoLinkedList<EXOLOCSTRING>::GetTail;
CExoLinkedListNode* (CExoLinkedList<EXOLOCSTRING>::*_689)() = &CExoLinkedList<EXOLOCSTRING>::GetTailPos;
int (CExoLinkedList<EXOLOCSTRING>::*_690)() = &CExoLinkedList<EXOLOCSTRING>::IsEmpty;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_691)() = &CExoLinkedList<EXOLOCSTRING>::RemoveHead;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_692)() = &CExoLinkedList<EXOLOCSTRING>::RemoveTail;
EXOLOCSTRING* (CExoLinkedList<EXOLOCSTRING>::*_693)(CExoLinkedListNode*) = &CExoLinkedList<EXOLOCSTRING>::Remove;
extern "C" { void CExoLinkedList____S_EXOLOCSTRING_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<EXOLOCSTRING>& _0) { ::new (__instance) CExoLinkedList<EXOLOCSTRING>(_0); } }
CExoLinkedList<EXOLOCSTRING>& (CExoLinkedList<EXOLOCSTRING>::*_694)(const CExoLinkedList<EXOLOCSTRING>&) = &CExoLinkedList<EXOLOCSTRING>::operator=;
template CExoLinkedList<CRes>::CExoLinkedList();
template CExoLinkedList<CRes>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CRes>::*_695)(CRes*) = &CExoLinkedList<CRes>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CRes>::*_696)(CRes*) = &CExoLinkedList<CRes>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CRes>::*_697)(CRes*, CExoLinkedListNode*) = &CExoLinkedList<CRes>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CRes>::*_698)(CRes*, CExoLinkedListNode*) = &CExoLinkedList<CRes>::AddBefore;
unsigned int (CExoLinkedList<CRes>::*_699)() = &CExoLinkedList<CRes>::Count;
CRes* (CExoLinkedList<CRes>::*_700)(CExoLinkedListNode*) = &CExoLinkedList<CRes>::GetAtPos;
CRes* (CExoLinkedList<CRes>::*_701)() = &CExoLinkedList<CRes>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CRes>::*_702)() = &CExoLinkedList<CRes>::GetHeadPos;
CRes* (CExoLinkedList<CRes>::*_703)(CExoLinkedListNode*&) = &CExoLinkedList<CRes>::GetNext;
CRes* (CExoLinkedList<CRes>::*_704)(CExoLinkedListNode*&) = &CExoLinkedList<CRes>::GetPrev;
CRes* (CExoLinkedList<CRes>::*_705)() = &CExoLinkedList<CRes>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CRes>::*_706)() = &CExoLinkedList<CRes>::GetTailPos;
int (CExoLinkedList<CRes>::*_707)() = &CExoLinkedList<CRes>::IsEmpty;
CRes* (CExoLinkedList<CRes>::*_708)() = &CExoLinkedList<CRes>::RemoveHead;
CRes* (CExoLinkedList<CRes>::*_709)() = &CExoLinkedList<CRes>::RemoveTail;
CRes* (CExoLinkedList<CRes>::*_710)(CExoLinkedListNode*) = &CExoLinkedList<CRes>::Remove;
extern "C" { void CExoLinkedList____S_CRes_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CRes>& _0) { ::new (__instance) CExoLinkedList<CRes>(_0); } }
CExoLinkedList<CRes>& (CExoLinkedList<CRes>::*_711)(const CExoLinkedList<CRes>&) = &CExoLinkedList<CRes>::operator=;
template CExoLinkedList<unsigned int>::CExoLinkedList();
template CExoLinkedList<unsigned int>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<unsigned int>::*_712)(unsigned int*) = &CExoLinkedList<unsigned int>::AddHead;
CExoLinkedListNode* (CExoLinkedList<unsigned int>::*_713)(unsigned int*) = &CExoLinkedList<unsigned int>::AddTail;
CExoLinkedListNode* (CExoLinkedList<unsigned int>::*_714)(unsigned int*, CExoLinkedListNode*) = &CExoLinkedList<unsigned int>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<unsigned int>::*_715)(unsigned int*, CExoLinkedListNode*) = &CExoLinkedList<unsigned int>::AddBefore;
unsigned int (CExoLinkedList<unsigned int>::*_716)() = &CExoLinkedList<unsigned int>::Count;
unsigned int* (CExoLinkedList<unsigned int>::*_717)(CExoLinkedListNode*) = &CExoLinkedList<unsigned int>::GetAtPos;
unsigned int* (CExoLinkedList<unsigned int>::*_718)() = &CExoLinkedList<unsigned int>::GetHead;
CExoLinkedListNode* (CExoLinkedList<unsigned int>::*_719)() = &CExoLinkedList<unsigned int>::GetHeadPos;
unsigned int* (CExoLinkedList<unsigned int>::*_720)(CExoLinkedListNode*&) = &CExoLinkedList<unsigned int>::GetNext;
unsigned int* (CExoLinkedList<unsigned int>::*_721)(CExoLinkedListNode*&) = &CExoLinkedList<unsigned int>::GetPrev;
unsigned int* (CExoLinkedList<unsigned int>::*_722)() = &CExoLinkedList<unsigned int>::GetTail;
CExoLinkedListNode* (CExoLinkedList<unsigned int>::*_723)() = &CExoLinkedList<unsigned int>::GetTailPos;
int (CExoLinkedList<unsigned int>::*_724)() = &CExoLinkedList<unsigned int>::IsEmpty;
unsigned int* (CExoLinkedList<unsigned int>::*_725)() = &CExoLinkedList<unsigned int>::RemoveHead;
unsigned int* (CExoLinkedList<unsigned int>::*_726)() = &CExoLinkedList<unsigned int>::RemoveTail;
unsigned int* (CExoLinkedList<unsigned int>::*_727)(CExoLinkedListNode*) = &CExoLinkedList<unsigned int>::Remove;
extern "C" { void CExoLinkedList__i_F_CExoLinkedList___1__S_CExoLinkedList__i(void* __instance, const CExoLinkedList<unsigned int>& _0) { ::new (__instance) CExoLinkedList<unsigned int>(_0); } }
CExoLinkedList<unsigned int>& (CExoLinkedList<unsigned int>::*_728)(const CExoLinkedList<unsigned int>&) = &CExoLinkedList<unsigned int>::operator=;
template CExoLinkedList<NWAREAEXPANSION>::CExoLinkedList();
template CExoLinkedList<NWAREAEXPANSION>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<NWAREAEXPANSION>::*_729)(NWAREAEXPANSION*) = &CExoLinkedList<NWAREAEXPANSION>::AddHead;
CExoLinkedListNode* (CExoLinkedList<NWAREAEXPANSION>::*_730)(NWAREAEXPANSION*) = &CExoLinkedList<NWAREAEXPANSION>::AddTail;
CExoLinkedListNode* (CExoLinkedList<NWAREAEXPANSION>::*_731)(NWAREAEXPANSION*, CExoLinkedListNode*) = &CExoLinkedList<NWAREAEXPANSION>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<NWAREAEXPANSION>::*_732)(NWAREAEXPANSION*, CExoLinkedListNode*) = &CExoLinkedList<NWAREAEXPANSION>::AddBefore;
unsigned int (CExoLinkedList<NWAREAEXPANSION>::*_733)() = &CExoLinkedList<NWAREAEXPANSION>::Count;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_734)(CExoLinkedListNode*) = &CExoLinkedList<NWAREAEXPANSION>::GetAtPos;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_735)() = &CExoLinkedList<NWAREAEXPANSION>::GetHead;
CExoLinkedListNode* (CExoLinkedList<NWAREAEXPANSION>::*_736)() = &CExoLinkedList<NWAREAEXPANSION>::GetHeadPos;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_737)(CExoLinkedListNode*&) = &CExoLinkedList<NWAREAEXPANSION>::GetNext;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_738)(CExoLinkedListNode*&) = &CExoLinkedList<NWAREAEXPANSION>::GetPrev;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_739)() = &CExoLinkedList<NWAREAEXPANSION>::GetTail;
CExoLinkedListNode* (CExoLinkedList<NWAREAEXPANSION>::*_740)() = &CExoLinkedList<NWAREAEXPANSION>::GetTailPos;
int (CExoLinkedList<NWAREAEXPANSION>::*_741)() = &CExoLinkedList<NWAREAEXPANSION>::IsEmpty;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_742)() = &CExoLinkedList<NWAREAEXPANSION>::RemoveHead;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_743)() = &CExoLinkedList<NWAREAEXPANSION>::RemoveTail;
NWAREAEXPANSION* (CExoLinkedList<NWAREAEXPANSION>::*_744)(CExoLinkedListNode*) = &CExoLinkedList<NWAREAEXPANSION>::Remove;
extern "C" { void CExoLinkedList____S_NWAREAEXPANSION_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<NWAREAEXPANSION>& _0) { ::new (__instance) CExoLinkedList<NWAREAEXPANSION>(_0); } }
CExoLinkedList<NWAREAEXPANSION>& (CExoLinkedList<NWAREAEXPANSION>::*_745)(const CExoLinkedList<NWAREAEXPANSION>&) = &CExoLinkedList<NWAREAEXPANSION>::operator=;
template CExoLinkedList<CNWSObjectActionNode>::CExoLinkedList();
template CExoLinkedList<CNWSObjectActionNode>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CNWSObjectActionNode>::*_746)(CNWSObjectActionNode*) = &CExoLinkedList<CNWSObjectActionNode>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CNWSObjectActionNode>::*_747)(CNWSObjectActionNode*) = &CExoLinkedList<CNWSObjectActionNode>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CNWSObjectActionNode>::*_748)(CNWSObjectActionNode*, CExoLinkedListNode*) = &CExoLinkedList<CNWSObjectActionNode>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CNWSObjectActionNode>::*_749)(CNWSObjectActionNode*, CExoLinkedListNode*) = &CExoLinkedList<CNWSObjectActionNode>::AddBefore;
unsigned int (CExoLinkedList<CNWSObjectActionNode>::*_750)() = &CExoLinkedList<CNWSObjectActionNode>::Count;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_751)(CExoLinkedListNode*) = &CExoLinkedList<CNWSObjectActionNode>::GetAtPos;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_752)() = &CExoLinkedList<CNWSObjectActionNode>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CNWSObjectActionNode>::*_753)() = &CExoLinkedList<CNWSObjectActionNode>::GetHeadPos;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_754)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSObjectActionNode>::GetNext;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_755)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSObjectActionNode>::GetPrev;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_756)() = &CExoLinkedList<CNWSObjectActionNode>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CNWSObjectActionNode>::*_757)() = &CExoLinkedList<CNWSObjectActionNode>::GetTailPos;
int (CExoLinkedList<CNWSObjectActionNode>::*_758)() = &CExoLinkedList<CNWSObjectActionNode>::IsEmpty;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_759)() = &CExoLinkedList<CNWSObjectActionNode>::RemoveHead;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_760)() = &CExoLinkedList<CNWSObjectActionNode>::RemoveTail;
CNWSObjectActionNode* (CExoLinkedList<CNWSObjectActionNode>::*_761)(CExoLinkedListNode*) = &CExoLinkedList<CNWSObjectActionNode>::Remove;
extern "C" { void CExoLinkedList____S_CNWSObjectActionNode_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CNWSObjectActionNode>& _0) { ::new (__instance) CExoLinkedList<CNWSObjectActionNode>(_0); } }
CExoLinkedList<CNWSObjectActionNode>& (CExoLinkedList<CNWSObjectActionNode>::*_762)(const CExoLinkedList<CNWSObjectActionNode>&) = &CExoLinkedList<CNWSObjectActionNode>::operator=;
template CExoLinkedList<CNWSDialogPlayer>::CExoLinkedList();
template CExoLinkedList<CNWSDialogPlayer>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CNWSDialogPlayer>::*_763)(CNWSDialogPlayer*) = &CExoLinkedList<CNWSDialogPlayer>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CNWSDialogPlayer>::*_764)(CNWSDialogPlayer*) = &CExoLinkedList<CNWSDialogPlayer>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CNWSDialogPlayer>::*_765)(CNWSDialogPlayer*, CExoLinkedListNode*) = &CExoLinkedList<CNWSDialogPlayer>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CNWSDialogPlayer>::*_766)(CNWSDialogPlayer*, CExoLinkedListNode*) = &CExoLinkedList<CNWSDialogPlayer>::AddBefore;
unsigned int (CExoLinkedList<CNWSDialogPlayer>::*_767)() = &CExoLinkedList<CNWSDialogPlayer>::Count;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_768)(CExoLinkedListNode*) = &CExoLinkedList<CNWSDialogPlayer>::GetAtPos;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_769)() = &CExoLinkedList<CNWSDialogPlayer>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CNWSDialogPlayer>::*_770)() = &CExoLinkedList<CNWSDialogPlayer>::GetHeadPos;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_771)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSDialogPlayer>::GetNext;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_772)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSDialogPlayer>::GetPrev;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_773)() = &CExoLinkedList<CNWSDialogPlayer>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CNWSDialogPlayer>::*_774)() = &CExoLinkedList<CNWSDialogPlayer>::GetTailPos;
int (CExoLinkedList<CNWSDialogPlayer>::*_775)() = &CExoLinkedList<CNWSDialogPlayer>::IsEmpty;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_776)() = &CExoLinkedList<CNWSDialogPlayer>::RemoveHead;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_777)() = &CExoLinkedList<CNWSDialogPlayer>::RemoveTail;
CNWSDialogPlayer* (CExoLinkedList<CNWSDialogPlayer>::*_778)(CExoLinkedListNode*) = &CExoLinkedList<CNWSDialogPlayer>::Remove;
extern "C" { void CExoLinkedList____S_CNWSDialogPlayer_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CNWSDialogPlayer>& _0) { ::new (__instance) CExoLinkedList<CNWSDialogPlayer>(_0); } }
CExoLinkedList<CNWSDialogPlayer>& (CExoLinkedList<CNWSDialogPlayer>::*_779)(const CExoLinkedList<CNWSDialogPlayer>&) = &CExoLinkedList<CNWSDialogPlayer>::operator=;
template CExoLinkedList<NWMODULEEXPANSION>::CExoLinkedList();
template CExoLinkedList<NWMODULEEXPANSION>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<NWMODULEEXPANSION>::*_780)(NWMODULEEXPANSION*) = &CExoLinkedList<NWMODULEEXPANSION>::AddHead;
CExoLinkedListNode* (CExoLinkedList<NWMODULEEXPANSION>::*_781)(NWMODULEEXPANSION*) = &CExoLinkedList<NWMODULEEXPANSION>::AddTail;
CExoLinkedListNode* (CExoLinkedList<NWMODULEEXPANSION>::*_782)(NWMODULEEXPANSION*, CExoLinkedListNode*) = &CExoLinkedList<NWMODULEEXPANSION>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<NWMODULEEXPANSION>::*_783)(NWMODULEEXPANSION*, CExoLinkedListNode*) = &CExoLinkedList<NWMODULEEXPANSION>::AddBefore;
unsigned int (CExoLinkedList<NWMODULEEXPANSION>::*_784)() = &CExoLinkedList<NWMODULEEXPANSION>::Count;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_785)(CExoLinkedListNode*) = &CExoLinkedList<NWMODULEEXPANSION>::GetAtPos;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_786)() = &CExoLinkedList<NWMODULEEXPANSION>::GetHead;
CExoLinkedListNode* (CExoLinkedList<NWMODULEEXPANSION>::*_787)() = &CExoLinkedList<NWMODULEEXPANSION>::GetHeadPos;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_788)(CExoLinkedListNode*&) = &CExoLinkedList<NWMODULEEXPANSION>::GetNext;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_789)(CExoLinkedListNode*&) = &CExoLinkedList<NWMODULEEXPANSION>::GetPrev;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_790)() = &CExoLinkedList<NWMODULEEXPANSION>::GetTail;
CExoLinkedListNode* (CExoLinkedList<NWMODULEEXPANSION>::*_791)() = &CExoLinkedList<NWMODULEEXPANSION>::GetTailPos;
int (CExoLinkedList<NWMODULEEXPANSION>::*_792)() = &CExoLinkedList<NWMODULEEXPANSION>::IsEmpty;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_793)() = &CExoLinkedList<NWMODULEEXPANSION>::RemoveHead;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_794)() = &CExoLinkedList<NWMODULEEXPANSION>::RemoveTail;
NWMODULEEXPANSION* (CExoLinkedList<NWMODULEEXPANSION>::*_795)(CExoLinkedListNode*) = &CExoLinkedList<NWMODULEEXPANSION>::Remove;
extern "C" { void CExoLinkedList____S_NWMODULEEXPANSION_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<NWMODULEEXPANSION>& _0) { ::new (__instance) CExoLinkedList<NWMODULEEXPANSION>(_0); } }
CExoLinkedList<NWMODULEEXPANSION>& (CExoLinkedList<NWMODULEEXPANSION>::*_796)(const CExoLinkedList<NWMODULEEXPANSION>&) = &CExoLinkedList<NWMODULEEXPANSION>::operator=;
template CExoLinkedList<NWMODULECUTSCENE>::CExoLinkedList();
template CExoLinkedList<NWMODULECUTSCENE>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<NWMODULECUTSCENE>::*_797)(NWMODULECUTSCENE*) = &CExoLinkedList<NWMODULECUTSCENE>::AddHead;
CExoLinkedListNode* (CExoLinkedList<NWMODULECUTSCENE>::*_798)(NWMODULECUTSCENE*) = &CExoLinkedList<NWMODULECUTSCENE>::AddTail;
CExoLinkedListNode* (CExoLinkedList<NWMODULECUTSCENE>::*_799)(NWMODULECUTSCENE*, CExoLinkedListNode*) = &CExoLinkedList<NWMODULECUTSCENE>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<NWMODULECUTSCENE>::*_800)(NWMODULECUTSCENE*, CExoLinkedListNode*) = &CExoLinkedList<NWMODULECUTSCENE>::AddBefore;
unsigned int (CExoLinkedList<NWMODULECUTSCENE>::*_801)() = &CExoLinkedList<NWMODULECUTSCENE>::Count;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_802)(CExoLinkedListNode*) = &CExoLinkedList<NWMODULECUTSCENE>::GetAtPos;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_803)() = &CExoLinkedList<NWMODULECUTSCENE>::GetHead;
CExoLinkedListNode* (CExoLinkedList<NWMODULECUTSCENE>::*_804)() = &CExoLinkedList<NWMODULECUTSCENE>::GetHeadPos;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_805)(CExoLinkedListNode*&) = &CExoLinkedList<NWMODULECUTSCENE>::GetNext;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_806)(CExoLinkedListNode*&) = &CExoLinkedList<NWMODULECUTSCENE>::GetPrev;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_807)() = &CExoLinkedList<NWMODULECUTSCENE>::GetTail;
CExoLinkedListNode* (CExoLinkedList<NWMODULECUTSCENE>::*_808)() = &CExoLinkedList<NWMODULECUTSCENE>::GetTailPos;
int (CExoLinkedList<NWMODULECUTSCENE>::*_809)() = &CExoLinkedList<NWMODULECUTSCENE>::IsEmpty;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_810)() = &CExoLinkedList<NWMODULECUTSCENE>::RemoveHead;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_811)() = &CExoLinkedList<NWMODULECUTSCENE>::RemoveTail;
NWMODULECUTSCENE* (CExoLinkedList<NWMODULECUTSCENE>::*_812)(CExoLinkedListNode*) = &CExoLinkedList<NWMODULECUTSCENE>::Remove;
extern "C" { void CExoLinkedList____S_NWMODULECUTSCENE_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<NWMODULECUTSCENE>& _0) { ::new (__instance) CExoLinkedList<NWMODULECUTSCENE>(_0); } }
CExoLinkedList<NWMODULECUTSCENE>& (CExoLinkedList<NWMODULECUTSCENE>::*_813)(const CExoLinkedList<NWMODULECUTSCENE>&) = &CExoLinkedList<NWMODULECUTSCENE>::operator=;
template CExoLinkedList<CResRef>::CExoLinkedList();
template CExoLinkedList<CResRef>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CResRef>::*_814)(CResRef*) = &CExoLinkedList<CResRef>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CResRef>::*_815)(CResRef*) = &CExoLinkedList<CResRef>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CResRef>::*_816)(CResRef*, CExoLinkedListNode*) = &CExoLinkedList<CResRef>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CResRef>::*_817)(CResRef*, CExoLinkedListNode*) = &CExoLinkedList<CResRef>::AddBefore;
unsigned int (CExoLinkedList<CResRef>::*_818)() = &CExoLinkedList<CResRef>::Count;
CResRef* (CExoLinkedList<CResRef>::*_819)(CExoLinkedListNode*) = &CExoLinkedList<CResRef>::GetAtPos;
CResRef* (CExoLinkedList<CResRef>::*_820)() = &CExoLinkedList<CResRef>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CResRef>::*_821)() = &CExoLinkedList<CResRef>::GetHeadPos;
CResRef* (CExoLinkedList<CResRef>::*_822)(CExoLinkedListNode*&) = &CExoLinkedList<CResRef>::GetNext;
CResRef* (CExoLinkedList<CResRef>::*_823)(CExoLinkedListNode*&) = &CExoLinkedList<CResRef>::GetPrev;
CResRef* (CExoLinkedList<CResRef>::*_824)() = &CExoLinkedList<CResRef>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CResRef>::*_825)() = &CExoLinkedList<CResRef>::GetTailPos;
int (CExoLinkedList<CResRef>::*_826)() = &CExoLinkedList<CResRef>::IsEmpty;
CResRef* (CExoLinkedList<CResRef>::*_827)() = &CExoLinkedList<CResRef>::RemoveHead;
CResRef* (CExoLinkedList<CResRef>::*_828)() = &CExoLinkedList<CResRef>::RemoveTail;
CResRef* (CExoLinkedList<CResRef>::*_829)(CExoLinkedListNode*) = &CExoLinkedList<CResRef>::Remove;
extern "C" { void CExoLinkedList____S_CResRef_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CResRef>& _0) { ::new (__instance) CExoLinkedList<CResRef>(_0); } }
CExoLinkedList<CResRef>& (CExoLinkedList<CResRef>::*_830)(const CExoLinkedList<CResRef>&) = &CExoLinkedList<CResRef>::operator=;
template CExoLinkedList<NWPLAYERLISTITEM>::CExoLinkedList();
template CExoLinkedList<NWPLAYERLISTITEM>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<NWPLAYERLISTITEM>::*_831)(NWPLAYERLISTITEM*) = &CExoLinkedList<NWPLAYERLISTITEM>::AddHead;
CExoLinkedListNode* (CExoLinkedList<NWPLAYERLISTITEM>::*_832)(NWPLAYERLISTITEM*) = &CExoLinkedList<NWPLAYERLISTITEM>::AddTail;
CExoLinkedListNode* (CExoLinkedList<NWPLAYERLISTITEM>::*_833)(NWPLAYERLISTITEM*, CExoLinkedListNode*) = &CExoLinkedList<NWPLAYERLISTITEM>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<NWPLAYERLISTITEM>::*_834)(NWPLAYERLISTITEM*, CExoLinkedListNode*) = &CExoLinkedList<NWPLAYERLISTITEM>::AddBefore;
unsigned int (CExoLinkedList<NWPLAYERLISTITEM>::*_835)() = &CExoLinkedList<NWPLAYERLISTITEM>::Count;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_836)(CExoLinkedListNode*) = &CExoLinkedList<NWPLAYERLISTITEM>::GetAtPos;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_837)() = &CExoLinkedList<NWPLAYERLISTITEM>::GetHead;
CExoLinkedListNode* (CExoLinkedList<NWPLAYERLISTITEM>::*_838)() = &CExoLinkedList<NWPLAYERLISTITEM>::GetHeadPos;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_839)(CExoLinkedListNode*&) = &CExoLinkedList<NWPLAYERLISTITEM>::GetNext;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_840)(CExoLinkedListNode*&) = &CExoLinkedList<NWPLAYERLISTITEM>::GetPrev;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_841)() = &CExoLinkedList<NWPLAYERLISTITEM>::GetTail;
CExoLinkedListNode* (CExoLinkedList<NWPLAYERLISTITEM>::*_842)() = &CExoLinkedList<NWPLAYERLISTITEM>::GetTailPos;
int (CExoLinkedList<NWPLAYERLISTITEM>::*_843)() = &CExoLinkedList<NWPLAYERLISTITEM>::IsEmpty;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_844)() = &CExoLinkedList<NWPLAYERLISTITEM>::RemoveHead;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_845)() = &CExoLinkedList<NWPLAYERLISTITEM>::RemoveTail;
NWPLAYERLISTITEM* (CExoLinkedList<NWPLAYERLISTITEM>::*_846)(CExoLinkedListNode*) = &CExoLinkedList<NWPLAYERLISTITEM>::Remove;
extern "C" { void CExoLinkedList____S_NWPLAYERLISTITEM_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<NWPLAYERLISTITEM>& _0) { ::new (__instance) CExoLinkedList<NWPLAYERLISTITEM>(_0); } }
CExoLinkedList<NWPLAYERLISTITEM>& (CExoLinkedList<NWPLAYERLISTITEM>::*_847)(const CExoLinkedList<NWPLAYERLISTITEM>&) = &CExoLinkedList<NWPLAYERLISTITEM>::operator=;
template CExoLinkedList<CNWSPlayerTURD>::CExoLinkedList();
template CExoLinkedList<CNWSPlayerTURD>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerTURD>::*_848)(CNWSPlayerTURD*) = &CExoLinkedList<CNWSPlayerTURD>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerTURD>::*_849)(CNWSPlayerTURD*) = &CExoLinkedList<CNWSPlayerTURD>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerTURD>::*_850)(CNWSPlayerTURD*, CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerTURD>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerTURD>::*_851)(CNWSPlayerTURD*, CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerTURD>::AddBefore;
unsigned int (CExoLinkedList<CNWSPlayerTURD>::*_852)() = &CExoLinkedList<CNWSPlayerTURD>::Count;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_853)(CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerTURD>::GetAtPos;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_854)() = &CExoLinkedList<CNWSPlayerTURD>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerTURD>::*_855)() = &CExoLinkedList<CNWSPlayerTURD>::GetHeadPos;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_856)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSPlayerTURD>::GetNext;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_857)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSPlayerTURD>::GetPrev;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_858)() = &CExoLinkedList<CNWSPlayerTURD>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerTURD>::*_859)() = &CExoLinkedList<CNWSPlayerTURD>::GetTailPos;
int (CExoLinkedList<CNWSPlayerTURD>::*_860)() = &CExoLinkedList<CNWSPlayerTURD>::IsEmpty;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_861)() = &CExoLinkedList<CNWSPlayerTURD>::RemoveHead;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_862)() = &CExoLinkedList<CNWSPlayerTURD>::RemoveTail;
CNWSPlayerTURD* (CExoLinkedList<CNWSPlayerTURD>::*_863)(CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerTURD>::Remove;
extern "C" { void CExoLinkedList____S_CNWSPlayerTURD_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CNWSPlayerTURD>& _0) { ::new (__instance) CExoLinkedList<CNWSPlayerTURD>(_0); } }
CExoLinkedList<CNWSPlayerTURD>& (CExoLinkedList<CNWSPlayerTURD>::*_864)(const CExoLinkedList<CNWSPlayerTURD>&) = &CExoLinkedList<CNWSPlayerTURD>::operator=;
template CExoLinkedList<CNWSPlayerLUOInventoryItem>::CExoLinkedList();
template CExoLinkedList<CNWSPlayerLUOInventoryItem>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_865)(CNWSPlayerLUOInventoryItem*) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_866)(CNWSPlayerLUOInventoryItem*) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_867)(CNWSPlayerLUOInventoryItem*, CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_868)(CNWSPlayerLUOInventoryItem*, CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::AddBefore;
unsigned int (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_869)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::Count;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_870)(CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetAtPos;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_871)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_872)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetHeadPos;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_873)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetNext;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_874)(CExoLinkedListNode*&) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetPrev;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_875)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_876)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::GetTailPos;
int (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_877)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::IsEmpty;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_878)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::RemoveHead;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_879)() = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::RemoveTail;
CNWSPlayerLUOInventoryItem* (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_880)(CExoLinkedListNode*) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::Remove;
extern "C" { void CExoLinkedList____S_CNWSPlayerLUOInventoryItem_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CNWSPlayerLUOInventoryItem>& _0) { ::new (__instance) CExoLinkedList<CNWSPlayerLUOInventoryItem>(_0); } }
CExoLinkedList<CNWSPlayerLUOInventoryItem>& (CExoLinkedList<CNWSPlayerLUOInventoryItem>::*_881)(const CExoLinkedList<CNWSPlayerLUOInventoryItem>&) = &CExoLinkedList<CNWSPlayerLUOInventoryItem>::operator=;
template CExoLinkedList<CExoString>::CExoLinkedList();
template CExoLinkedList<CExoString>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CExoString>::*_882)(CExoString*) = &CExoLinkedList<CExoString>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CExoString>::*_883)(CExoString*) = &CExoLinkedList<CExoString>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CExoString>::*_884)(CExoString*, CExoLinkedListNode*) = &CExoLinkedList<CExoString>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CExoString>::*_885)(CExoString*, CExoLinkedListNode*) = &CExoLinkedList<CExoString>::AddBefore;
unsigned int (CExoLinkedList<CExoString>::*_886)() = &CExoLinkedList<CExoString>::Count;
CExoString* (CExoLinkedList<CExoString>::*_887)(CExoLinkedListNode*) = &CExoLinkedList<CExoString>::GetAtPos;
CExoString* (CExoLinkedList<CExoString>::*_888)() = &CExoLinkedList<CExoString>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CExoString>::*_889)() = &CExoLinkedList<CExoString>::GetHeadPos;
CExoString* (CExoLinkedList<CExoString>::*_890)(CExoLinkedListNode*&) = &CExoLinkedList<CExoString>::GetNext;
CExoString* (CExoLinkedList<CExoString>::*_891)(CExoLinkedListNode*&) = &CExoLinkedList<CExoString>::GetPrev;
CExoString* (CExoLinkedList<CExoString>::*_892)() = &CExoLinkedList<CExoString>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CExoString>::*_893)() = &CExoLinkedList<CExoString>::GetTailPos;
int (CExoLinkedList<CExoString>::*_894)() = &CExoLinkedList<CExoString>::IsEmpty;
CExoString* (CExoLinkedList<CExoString>::*_895)() = &CExoLinkedList<CExoString>::RemoveHead;
CExoString* (CExoLinkedList<CExoString>::*_896)() = &CExoLinkedList<CExoString>::RemoveTail;
CExoString* (CExoLinkedList<CExoString>::*_897)(CExoLinkedListNode*) = &CExoLinkedList<CExoString>::Remove;
extern "C" { void CExoLinkedList____S_CExoString_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CExoString>& _0) { ::new (__instance) CExoLinkedList<CExoString>(_0); } }
CExoLinkedList<CExoString>& (CExoLinkedList<CExoString>::*_898)(const CExoLinkedList<CExoString>&) = &CExoLinkedList<CExoString>::operator=;
template CExoLinkedList<CServerAIEventNode>::CExoLinkedList();
template CExoLinkedList<CServerAIEventNode>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<CServerAIEventNode>::*_899)(CServerAIEventNode*) = &CExoLinkedList<CServerAIEventNode>::AddHead;
CExoLinkedListNode* (CExoLinkedList<CServerAIEventNode>::*_900)(CServerAIEventNode*) = &CExoLinkedList<CServerAIEventNode>::AddTail;
CExoLinkedListNode* (CExoLinkedList<CServerAIEventNode>::*_901)(CServerAIEventNode*, CExoLinkedListNode*) = &CExoLinkedList<CServerAIEventNode>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<CServerAIEventNode>::*_902)(CServerAIEventNode*, CExoLinkedListNode*) = &CExoLinkedList<CServerAIEventNode>::AddBefore;
unsigned int (CExoLinkedList<CServerAIEventNode>::*_903)() = &CExoLinkedList<CServerAIEventNode>::Count;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_904)(CExoLinkedListNode*) = &CExoLinkedList<CServerAIEventNode>::GetAtPos;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_905)() = &CExoLinkedList<CServerAIEventNode>::GetHead;
CExoLinkedListNode* (CExoLinkedList<CServerAIEventNode>::*_906)() = &CExoLinkedList<CServerAIEventNode>::GetHeadPos;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_907)(CExoLinkedListNode*&) = &CExoLinkedList<CServerAIEventNode>::GetNext;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_908)(CExoLinkedListNode*&) = &CExoLinkedList<CServerAIEventNode>::GetPrev;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_909)() = &CExoLinkedList<CServerAIEventNode>::GetTail;
CExoLinkedListNode* (CExoLinkedList<CServerAIEventNode>::*_910)() = &CExoLinkedList<CServerAIEventNode>::GetTailPos;
int (CExoLinkedList<CServerAIEventNode>::*_911)() = &CExoLinkedList<CServerAIEventNode>::IsEmpty;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_912)() = &CExoLinkedList<CServerAIEventNode>::RemoveHead;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_913)() = &CExoLinkedList<CServerAIEventNode>::RemoveTail;
CServerAIEventNode* (CExoLinkedList<CServerAIEventNode>::*_914)(CExoLinkedListNode*) = &CExoLinkedList<CServerAIEventNode>::Remove;
extern "C" { void CExoLinkedList____S_CServerAIEventNode_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<CServerAIEventNode>& _0) { ::new (__instance) CExoLinkedList<CServerAIEventNode>(_0); } }
CExoLinkedList<CServerAIEventNode>& (CExoLinkedList<CServerAIEventNode>::*_915)(const CExoLinkedList<CServerAIEventNode>&) = &CExoLinkedList<CServerAIEventNode>::operator=;
template CExoLinkedList<C2DA>::CExoLinkedList();
template CExoLinkedList<C2DA>::~CExoLinkedList() noexcept;
CExoLinkedListNode* (CExoLinkedList<C2DA>::*_916)(C2DA*) = &CExoLinkedList<C2DA>::AddHead;
CExoLinkedListNode* (CExoLinkedList<C2DA>::*_917)(C2DA*) = &CExoLinkedList<C2DA>::AddTail;
CExoLinkedListNode* (CExoLinkedList<C2DA>::*_918)(C2DA*, CExoLinkedListNode*) = &CExoLinkedList<C2DA>::AddAfter;
CExoLinkedListNode* (CExoLinkedList<C2DA>::*_919)(C2DA*, CExoLinkedListNode*) = &CExoLinkedList<C2DA>::AddBefore;
unsigned int (CExoLinkedList<C2DA>::*_920)() = &CExoLinkedList<C2DA>::Count;
C2DA* (CExoLinkedList<C2DA>::*_921)(CExoLinkedListNode*) = &CExoLinkedList<C2DA>::GetAtPos;
C2DA* (CExoLinkedList<C2DA>::*_922)() = &CExoLinkedList<C2DA>::GetHead;
CExoLinkedListNode* (CExoLinkedList<C2DA>::*_923)() = &CExoLinkedList<C2DA>::GetHeadPos;
C2DA* (CExoLinkedList<C2DA>::*_924)(CExoLinkedListNode*&) = &CExoLinkedList<C2DA>::GetNext;
C2DA* (CExoLinkedList<C2DA>::*_925)(CExoLinkedListNode*&) = &CExoLinkedList<C2DA>::GetPrev;
C2DA* (CExoLinkedList<C2DA>::*_926)() = &CExoLinkedList<C2DA>::GetTail;
CExoLinkedListNode* (CExoLinkedList<C2DA>::*_927)() = &CExoLinkedList<C2DA>::GetTailPos;
int (CExoLinkedList<C2DA>::*_928)() = &CExoLinkedList<C2DA>::IsEmpty;
C2DA* (CExoLinkedList<C2DA>::*_929)() = &CExoLinkedList<C2DA>::RemoveHead;
C2DA* (CExoLinkedList<C2DA>::*_930)() = &CExoLinkedList<C2DA>::RemoveTail;
C2DA* (CExoLinkedList<C2DA>::*_931)(CExoLinkedListNode*) = &CExoLinkedList<C2DA>::Remove;
extern "C" { void CExoLinkedList____S_C2DA_F_CExoLinkedList___1__S_CExoLinkedList__S0(void* __instance, const CExoLinkedList<C2DA>& _0) { ::new (__instance) CExoLinkedList<C2DA>(_0); } }
CExoLinkedList<C2DA>& (CExoLinkedList<C2DA>::*_932)(const CExoLinkedList<C2DA>&) = &CExoLinkedList<C2DA>::operator=;
extern "C" { void NWERFHEADER_NWERFHEADER___1__S_NWERFHEADER(void* __instance, const NWERFHEADER& _0) { ::new (__instance) NWERFHEADER(_0); } }
extern "C" { void NWERFHEADER_NWERFHEADER(void* __instance) { ::new (__instance) NWERFHEADER(); } }
NWERFHEADER& (NWERFHEADER::*_933)(NWERFHEADER&&) = &NWERFHEADER::operator=;
extern "C" { void CExoAliasList_CExoAliasList___1__S_CExoAliasList(void* __instance, const CExoAliasList& _0) { ::new (__instance) CExoAliasList(_0); } }
CExoAliasList& (CExoAliasList::*_934)(const CExoAliasList&) = &CExoAliasList::operator=;
extern "C" { void CExoApp_CExoApp___1__S_CExoApp(void* __instance, const CExoApp& _0) { ::new (__instance) CExoApp(_0); } }
CExoApp& (CExoApp::*_935)(const CExoApp&) = &CExoApp::operator=;
extern "C" { void CExoBase_CExoBase___1__S_CExoBase(void* __instance, const CExoBase& _0) { ::new (__instance) CExoBase(_0); } }
CExoBase& (CExoBase::*_936)(const CExoBase&) = &CExoBase::operator=;
extern "C" { void CFileInfo_CFileInfo___1__S_CFileInfo(void* __instance, const CFileInfo& _0) { ::new (__instance) CFileInfo(_0); } }
CFileInfo& (CFileInfo::*_937)(CFileInfo&&) = &CFileInfo::operator=;
extern "C" { void CFileInfo__CFileInfo(CFileInfo* __instance) { delete __instance; } };
extern "C" { void CFileInfo_CFileInfo(void* __instance) { ::new (__instance) CFileInfo(); } }
extern "C" { void CExoBaseInternal_CExoBaseInternal___1__S_CExoBaseInternal(void* __instance, const CExoBaseInternal& _0) { ::new (__instance) CExoBaseInternal(_0); } }
CExoBaseInternal& (CExoBaseInternal::*_938)(const CExoBaseInternal&) = &CExoBaseInternal::operator=;
extern "C" { void CExoCriticalSection_CExoCriticalSection___1__S_CExoCriticalSection(void* __instance, const CExoCriticalSection& _0) { ::new (__instance) CExoCriticalSection(_0); } }
CExoCriticalSection& (CExoCriticalSection::*_939)(const CExoCriticalSection&) = &CExoCriticalSection::operator=;
extern "C" { void CExoDebug_CExoDebug___1__S_CExoDebug(void* __instance, const CExoDebug& _0) { ::new (__instance) CExoDebug(_0); } }
CExoDebug& (CExoDebug::*_940)(const CExoDebug&) = &CExoDebug::operator=;
extern "C" { void CExoDebugInternal_CExoDebugInternal___1__S_CExoDebugInternal(void* __instance, const CExoDebugInternal& _0) { ::new (__instance) CExoDebugInternal(_0); } }
CExoDebugInternal& (CExoDebugInternal::*_941)(const CExoDebugInternal&) = &CExoDebugInternal::operator=;
extern "C" { void CExoEncapsulatedFile_CExoEncapsulatedFile___1__S_CExoEncapsulatedFile(void* __instance, const CExoEncapsulatedFile& _0) { ::new (__instance) CExoEncapsulatedFile(_0); } }
CExoEncapsulatedFile& (CExoEncapsulatedFile::*_942)(const CExoEncapsulatedFile&) = &CExoEncapsulatedFile::operator=;
extern "C" { void CExoPackedFile_CExoPackedFile___1__S_CExoPackedFile(void* __instance, const CExoPackedFile& _0) { ::new (__instance) CExoPackedFile(_0); } }
CExoPackedFile& (CExoPackedFile::*_943)(const CExoPackedFile&) = &CExoPackedFile::operator=;
extern "C" { void CExoEncrypt_CExoEncrypt(void* __instance) { ::new (__instance) CExoEncrypt(); } }
extern "C" { void CExoEncrypt_CExoEncrypt___1__S_CExoEncrypt(void* __instance, const CExoEncrypt& _0) { ::new (__instance) CExoEncrypt(_0); } }
CExoEncrypt& (CExoEncrypt::*_944)(CExoEncrypt&&) = &CExoEncrypt::operator=;
CExoFile& (CExoFile::*_945)(const CExoFile&) = &CExoFile::operator=;
extern "C" { void CExoFile_CExoFile___1__S_CExoFile(void* __instance, const CExoFile& _0) { ::new (__instance) CExoFile(_0); } }
extern "C" { void CExoIdentity_CExoIdentity(void* __instance) { ::new (__instance) CExoIdentity(); } }
extern "C" { void CExoIdentity_CExoIdentity___1__S_CExoIdentity(void* __instance, const CExoIdentity& _0) { ::new (__instance) CExoIdentity(_0); } }
CExoIdentity& (CExoIdentity::*_946)(CExoIdentity&&) = &CExoIdentity::operator=;
extern "C" { void CExoIni_CExoIni___1__S_CExoIni(void* __instance, const CExoIni& _0) { ::new (__instance) CExoIni(_0); } }
CExoIni& (CExoIni::*_947)(const CExoIni&) = &CExoIni::operator=;
extern "C" { void CExoIniInternal_CExoIniInternal___1__S_CExoIniInternal(void* __instance, const CExoIniInternal& _0) { ::new (__instance) CExoIniInternal(_0); } }
CExoIniInternal& (CExoIniInternal::*_948)(const CExoIniInternal&) = &CExoIniInternal::operator=;
CExoInput& (CExoInput::*_949)(const CExoInput&) = &CExoInput::operator=;
extern "C" { void CExoInput_CExoInput___1__S_CExoInput(void* __instance, const CExoInput& _0) { ::new (__instance) CExoInput(_0); } }
extern "C" { void CExoInputClass_CExoInputClass___1__S_CExoInputClass(void* __instance, const CExoInputClass& _0) { ::new (__instance) CExoInputClass(_0); } }
CExoInputClass& (CExoInputClass::*_950)(CExoInputClass&&) = &CExoInputClass::operator=;
extern "C" { void CExoInputClass__CExoInputClass(CExoInputClass* __instance) { delete __instance; } };
extern "C" { void CExoInputClass_CExoInputClass(void* __instance) { ::new (__instance) CExoInputClass(); } }
extern "C" { void CExoInputEventDesc_CExoInputEventDesc___1__S_CExoInputEventDesc(void* __instance, const CExoInputEventDesc& _0) { ::new (__instance) CExoInputEventDesc(_0); } }
CExoInputEventDesc& (CExoInputEventDesc::*_951)(CExoInputEventDesc&&) = &CExoInputEventDesc::operator=;
extern "C" { void CExoInputEventDesc__CExoInputEventDesc(CExoInputEventDesc* __instance) { delete __instance; } };
extern "C" { void CExoInputEventDesc_CExoInputEventDesc(void* __instance) { ::new (__instance) CExoInputEventDesc(); } }
extern "C" { void CExoInputEvent_CExoInputEvent(void* __instance) { ::new (__instance) CExoInputEvent(); } }
extern "C" { void CExoInputEvent_CExoInputEvent___1__S_CExoInputEvent(void* __instance, const CExoInputEvent& _0) { ::new (__instance) CExoInputEvent(_0); } }
CExoInputEvent& (CExoInputEvent::*_952)(CExoInputEvent&&) = &CExoInputEvent::operator=;
extern "C" { void CExoKeyTable_CExoKeyTable___1__S_CExoKeyTable(void* __instance, const CExoKeyTable& _0) { ::new (__instance) CExoKeyTable(_0); } }
CExoKeyTable& (CExoKeyTable::*_953)(const CExoKeyTable&) = &CExoKeyTable::operator=;
extern "C" { void KEYFILE_HEADER_KEYFILE_HEADER___1__S_KEYFILE_HEADER(void* __instance, const KEYFILE_HEADER& _0) { ::new (__instance) KEYFILE_HEADER(_0); } }
KEYFILE_HEADER& (KEYFILE_HEADER::*_954)(KEYFILE_HEADER&&) = &KEYFILE_HEADER::operator=;
extern "C" { void KEYFILE_HEADER_KEYFILE_HEADER(void* __instance) { ::new (__instance) KEYFILE_HEADER(); } }
extern "C" { void CKeyTableInfo_CKeyTableInfo___1__S_CKeyTableInfo(void* __instance, const CKeyTableInfo& _0) { ::new (__instance) CKeyTableInfo(_0); } }
CKeyTableInfo& (CKeyTableInfo::*_955)(CKeyTableInfo&&) = &CKeyTableInfo::operator=;
extern "C" { void CKeyTableInfo__CKeyTableInfo(CKeyTableInfo* __instance) { delete __instance; } };
extern "C" { void CKeyTableInfo_CKeyTableInfo(void* __instance) { ::new (__instance) CKeyTableInfo(); } }
extern "C" { void CExoLocStringInternal_CExoLocStringInternal___1__S_CExoLocStringInternal(void* __instance, const CExoLocStringInternal& _0) { ::new (__instance) CExoLocStringInternal(_0); } }
CExoLocStringInternal& (CExoLocStringInternal::*_956)(const CExoLocStringInternal&) = &CExoLocStringInternal::operator=;
extern "C" { void EXOLOCSTRING_EXOLOCSTRING___1__S_EXOLOCSTRING(void* __instance, const EXOLOCSTRING& _0) { ::new (__instance) EXOLOCSTRING(_0); } }
EXOLOCSTRING& (EXOLOCSTRING::*_957)(EXOLOCSTRING&&) = &EXOLOCSTRING::operator=;
extern "C" { void EXOLOCSTRING__EXOLOCSTRING(EXOLOCSTRING* __instance) { delete __instance; } };
extern "C" { void EXOLOCSTRING_EXOLOCSTRING(void* __instance) { ::new (__instance) EXOLOCSTRING(); } }
extern "C" { void CExoRand_CExoRand___1__S_CExoRand(void* __instance, const CExoRand& _0) { ::new (__instance) CExoRand(_0); } }
CExoRand& (CExoRand::*_958)(const CExoRand&) = &CExoRand::operator=;
extern "C" { void CExoRandInternal_CExoRandInternal___1__S_CExoRandInternal(void* __instance, const CExoRandInternal& _0) { ::new (__instance) CExoRandInternal(_0); } }
CExoRandInternal& (CExoRandInternal::*_959)(const CExoRandInternal&) = &CExoRandInternal::operator=;
extern "C" { void CExoResMan_CExoResMan___1__S_CExoResMan(void* __instance, const CExoResMan& _0) { ::new (__instance) CExoResMan(_0); } }
CExoResMan& (CExoResMan::*_960)(const CExoResMan&) = &CExoResMan::operator=;
extern "C" { void CNWSync_CNWSync___1__S_CNWSync(void* __instance, const CNWSync& _0) { ::new (__instance) CNWSync(_0); } }
CNWSync& (CNWSync::*_961)(CNWSync&&) = &CNWSync::operator=;
extern "C" { void CNWSync_CNWSync(void* __instance) { ::new (__instance) CNWSync(); } }
extern "C" { void CExoResourceImageFile_CExoResourceImageFile___1__S_CExoResourceImageFile(void* __instance, const CExoResourceImageFile& _0) { ::new (__instance) CExoResourceImageFile(_0); } }
CExoResourceImageFile& (CExoResourceImageFile::*_962)(const CExoResourceImageFile&) = &CExoResourceImageFile::operator=;
extern "C" { void ENCAPSULATED_KEYLISTENTRY_ENCAPSULATED_KEYLISTENTRY(void* __instance) { ::new (__instance) ENCAPSULATED_KEYLISTENTRY(); } }
extern "C" { void ENCAPSULATED_KEYLISTENTRY_ENCAPSULATED_KEYLISTENTRY___1__S_ENCAPSULATED_KEYLISTENTRY(void* __instance, const ENCAPSULATED_KEYLISTENTRY& _0) { ::new (__instance) ENCAPSULATED_KEYLISTENTRY(_0); } }
ENCAPSULATED_KEYLISTENTRY& (ENCAPSULATED_KEYLISTENTRY::*_963)(ENCAPSULATED_KEYLISTENTRY&&) = &ENCAPSULATED_KEYLISTENTRY::operator=;
extern "C" { void CExoStringList_CExoStringList___1__S_CExoStringList(void* __instance, const CExoStringList& _0) { ::new (__instance) CExoStringList(_0); } }
extern "C" { void CExoTimers_CExoTimers___1__S_CExoTimers(void* __instance, const CExoTimers& _0) { ::new (__instance) CExoTimers(_0); } }
CExoTimers& (CExoTimers::*_964)(const CExoTimers&) = &CExoTimers::operator=;
extern "C" { void CExoTimersInternal_CExoTimersInternal___1__S_CExoTimersInternal(void* __instance, const CExoTimersInternal& _0) { ::new (__instance) CExoTimersInternal(_0); } }
CExoTimersInternal& (CExoTimersInternal::*_965)(const CExoTimersInternal&) = &CExoTimersInternal::operator=;
extern "C" { void CExtendedServerInfo_CExtendedServerInfo___1__S_CExtendedServerInfo(void* __instance, const CExtendedServerInfo& _0) { ::new (__instance) CExtendedServerInfo(_0); } }
CExtendedServerInfo& (CExtendedServerInfo::*_966)(CExtendedServerInfo&&) = &CExtendedServerInfo::operator=;
extern "C" { void CExtendedServerInfo__CExtendedServerInfo(CExtendedServerInfo* __instance) { delete __instance; } };
extern "C" { void CExtendedServerInfo_CExtendedServerInfo(void* __instance) { ::new (__instance) CExtendedServerInfo(); } }
extern "C" { void CFactionManager_CFactionManager___1__S_CFactionManager(void* __instance, const CFactionManager& _0) { ::new (__instance) CFactionManager(_0); } }
CFactionManager& (CFactionManager::*_967)(const CFactionManager&) = &CFactionManager::operator=;
extern "C" { void CFeatUseListEntry_CFeatUseListEntry(void* __instance) { ::new (__instance) CFeatUseListEntry(); } }
extern "C" { void CFeatUseListEntry_CFeatUseListEntry___1__S_CFeatUseListEntry(void* __instance, const CFeatUseListEntry& _0) { ::new (__instance) CFeatUseListEntry(_0); } }
CFeatUseListEntry& (CFeatUseListEntry::*_968)(CFeatUseListEntry&&) = &CFeatUseListEntry::operator=;
CGameEffectApplierRemover& (CGameEffectApplierRemover::*_969)(const CGameEffectApplierRemover&) = &CGameEffectApplierRemover::operator=;
extern "C" { void CGameEffectApplierRemover_CGameEffectApplierRemover(void* __instance) { ::new (__instance) CGameEffectApplierRemover(); } }
extern "C" { void CGameEffectApplierRemover_CGameEffectApplierRemover___1__S_CGameEffectApplierRemover(void* __instance, const CGameEffectApplierRemover& _0) { ::new (__instance) CGameEffectApplierRemover(_0); } }
CGameObject& (CGameObject::*_970)(const CGameObject&) = &CGameObject::operator=;
extern "C" { void CGameObject_CGameObject___1__S_CGameObject(void* __instance, const CGameObject& _0) { ::new (__instance) CGameObject(_0); } }
extern "C" { void CGameObjectArray_CGameObjectArray___1__S_CGameObjectArray(void* __instance, const CGameObjectArray& _0) { ::new (__instance) CGameObjectArray(_0); } }
CGameObjectArray& (CGameObjectArray::*_971)(const CGameObjectArray&) = &CGameObjectArray::operator=;
extern "C" { void CGameObjectArrayNode_CGameObjectArrayNode(void* __instance) { ::new (__instance) CGameObjectArrayNode(); } }
extern "C" { void CGameObjectArrayNode_CGameObjectArrayNode___1__S_CGameObjectArrayNode(void* __instance, const CGameObjectArrayNode& _0) { ::new (__instance) CGameObjectArrayNode(_0); } }
CGameObjectArrayNode& (CGameObjectArrayNode::*_972)(CGameObjectArrayNode&&) = &CGameObjectArrayNode::operator=;
CItemPropertyApplierRemover& (CItemPropertyApplierRemover::*_973)(const CItemPropertyApplierRemover&) = &CItemPropertyApplierRemover::operator=;
extern "C" { void CItemPropertyApplierRemover_CItemPropertyApplierRemover(void* __instance) { ::new (__instance) CItemPropertyApplierRemover(); } }
extern "C" { void CItemPropertyApplierRemover_CItemPropertyApplierRemover___1__S_CItemPropertyApplierRemover(void* __instance, const CItemPropertyApplierRemover& _0) { ::new (__instance) CItemPropertyApplierRemover(_0); } }
extern "C" { void CItemRepository_CItemRepository___1__S_CItemRepository(void* __instance, const CItemRepository& _0) { ::new (__instance) CItemRepository(_0); } }
CItemRepository& (CItemRepository::*_974)(const CItemRepository&) = &CItemRepository::operator=;
extern "C" { void CJoiningRestrictions_CJoiningRestrictions(void* __instance) { ::new (__instance) CJoiningRestrictions(); } }
extern "C" { void CJoiningRestrictions_CJoiningRestrictions___1__S_CJoiningRestrictions(void* __instance, const CJoiningRestrictions& _0) { ::new (__instance) CJoiningRestrictions(_0); } }
CJoiningRestrictions& (CJoiningRestrictions::*_975)(CJoiningRestrictions&&) = &CJoiningRestrictions::operator=;
CKeyTableEntry& (CKeyTableEntry::*_976)(CKeyTableEntry&&) = &CKeyTableEntry::operator=;
extern "C" { void CKeyTableEntry_CKeyTableEntry(void* __instance) { ::new (__instance) CKeyTableEntry(); } }
extern "C" { void CKeyTableEntry_CKeyTableEntry___1__S_CKeyTableEntry(void* __instance, const CKeyTableEntry& _0) { ::new (__instance) CKeyTableEntry(_0); } }
extern "C" { void CLastUpdateObject_CLastUpdateObject___1__S_CLastUpdateObject(void* __instance, const CLastUpdateObject& _0) { ::new (__instance) CLastUpdateObject(_0); } }
CLastUpdateObject& (CLastUpdateObject::*_977)(const CLastUpdateObject&) = &CLastUpdateObject::operator=;
extern "C" { void ObjectVisualTransformData_ObjectVisualTransformData___1__S_ObjectVisualTransformData(void* __instance, const ObjectVisualTransformData& _0) { ::new (__instance) ObjectVisualTransformData(_0); } }
ObjectVisualTransformData& (ObjectVisualTransformData::*_978)(ObjectVisualTransformData&&) = &ObjectVisualTransformData::operator=;
extern "C" { void ObjectVisualTransformData_ObjectVisualTransformData(void* __instance) { ::new (__instance) ObjectVisualTransformData(); } }
extern "C" { void CNWSPlayerLUOAppearanceInfo_CNWSPlayerLUOAppearanceInfo___1__S_CNWSPlayerLUOAppearanceInfo(void* __instance, const CNWSPlayerLUOAppearanceInfo& _0) { ::new (__instance) CNWSPlayerLUOAppearanceInfo(_0); } }
CNWSPlayerLUOAppearanceInfo& (CNWSPlayerLUOAppearanceInfo::*_979)(CNWSPlayerLUOAppearanceInfo&&) = &CNWSPlayerLUOAppearanceInfo::operator=;
extern "C" { void CNWSPlayerLUOAppearanceInfo_CNWSPlayerLUOAppearanceInfo(void* __instance) { ::new (__instance) CNWSPlayerLUOAppearanceInfo(); } }
extern "C" { void MaterialShaderParam_MaterialShaderParam(void* __instance) { ::new (__instance) MaterialShaderParam(); } }
extern "C" { void MaterialShaderParam_MaterialShaderParam___1__S_MaterialShaderParam(void* __instance, const MaterialShaderParam& _0) { ::new (__instance) MaterialShaderParam(_0); } }
MaterialShaderParam& (MaterialShaderParam::*_980)(MaterialShaderParam&&) = &MaterialShaderParam::operator=;
extern "C" { void TextureReplaceInfo_TextureReplaceInfo(void* __instance) { ::new (__instance) TextureReplaceInfo(); } }
extern "C" { void TextureReplaceInfo_TextureReplaceInfo___1__S_TextureReplaceInfo(void* __instance, const TextureReplaceInfo& _0) { ::new (__instance) TextureReplaceInfo(_0); } }
TextureReplaceInfo& (TextureReplaceInfo::*_981)(TextureReplaceInfo&&) = &TextureReplaceInfo::operator=;
CLastUpdatePartyObject& (CLastUpdatePartyObject::*_982)(CLastUpdatePartyObject&&) = &CLastUpdatePartyObject::operator=;
extern "C" { void CLastUpdatePartyObject_CLastUpdatePartyObject(void* __instance) { ::new (__instance) CLastUpdatePartyObject(); } }
extern "C" { void CLastUpdatePartyObject_CLastUpdatePartyObject___1__S_CLastUpdatePartyObject(void* __instance, const CLastUpdatePartyObject& _0) { ::new (__instance) CLastUpdatePartyObject(_0); } }
extern "C" { void CLoopingVisualEffect_CLoopingVisualEffect(void* __instance) { ::new (__instance) CLoopingVisualEffect(); } }
extern "C" { void CLoopingVisualEffect_CLoopingVisualEffect___1__S_CLoopingVisualEffect(void* __instance, const CLoopingVisualEffect& _0) { ::new (__instance) CLoopingVisualEffect(_0); } }
CLoopingVisualEffect& (CLoopingVisualEffect::*_983)(CLoopingVisualEffect&&) = &CLoopingVisualEffect::operator=;
extern "C" { void CMessagePlayer_CMessagePlayer___1__S_CMessagePlayer(void* __instance, const CMessagePlayer& _0) { ::new (__instance) CMessagePlayer(_0); } }
CMessagePlayer& (CMessagePlayer::*_984)(const CMessagePlayer&) = &CMessagePlayer::operator=;
extern "C" { void CMessageSysAdmin_CMessageSysAdmin___1__S_CMessageSysAdmin(void* __instance, const CMessageSysAdmin& _0) { ::new (__instance) CMessageSysAdmin(_0); } }
CMessageSysAdmin& (CMessageSysAdmin::*_985)(const CMessageSysAdmin&) = &CMessageSysAdmin::operator=;
extern "C" { void CNetLayer_CNetLayer___1__S_CNetLayer(void* __instance, const CNetLayer& _0) { ::new (__instance) CNetLayer(_0); } }
CNetLayer& (CNetLayer::*_986)(const CNetLayer&) = &CNetLayer::operator=;
extern "C" { void CNetLayerPlayerCDKeyInfo_CNetLayerPlayerCDKeyInfo___1__S_CNetLayerPlayerCDKeyInfo(void* __instance, const CNetLayerPlayerCDKeyInfo& _0) { ::new (__instance) CNetLayerPlayerCDKeyInfo(_0); } }
CNetLayerPlayerCDKeyInfo& (CNetLayerPlayerCDKeyInfo::*_987)(CNetLayerPlayerCDKeyInfo&&) = &CNetLayerPlayerCDKeyInfo::operator=;
extern "C" { void CNetLayerPlayerCDKeyInfo__CNetLayerPlayerCDKeyInfo(CNetLayerPlayerCDKeyInfo* __instance) { delete __instance; } };
extern "C" { void CNetLayerPlayerCDKeyInfo_CNetLayerPlayerCDKeyInfo(void* __instance) { ::new (__instance) CNetLayerPlayerCDKeyInfo(); } }
extern "C" { void CNetLayerPlayerInfo_CNetLayerPlayerInfo___1__S_CNetLayerPlayerInfo(void* __instance, const CNetLayerPlayerInfo& _0) { ::new (__instance) CNetLayerPlayerInfo(_0); } }
CNetLayerPlayerInfo& (CNetLayerPlayerInfo::*_988)(CNetLayerPlayerInfo&&) = &CNetLayerPlayerInfo::operator=;
extern "C" { void CNetLayerPlayerInfo__CNetLayerPlayerInfo(CNetLayerPlayerInfo* __instance) { delete __instance; } };
extern "C" { void CNetLayerSessionInfo_CNetLayerSessionInfo___1__S_CNetLayerSessionInfo(void* __instance, const CNetLayerSessionInfo& _0) { ::new (__instance) CNetLayerSessionInfo(_0); } }
CNetLayerSessionInfo& (CNetLayerSessionInfo::*_989)(const CNetLayerSessionInfo&) = &CNetLayerSessionInfo::operator=;
extern "C" { void NWSyncAdvertisementManifest_NWSyncAdvertisementManifest___1__S_NWSyncAdvertisementManifest(void* __instance, const NWSyncAdvertisementManifest& _0) { ::new (__instance) NWSyncAdvertisementManifest(_0); } }
NWSyncAdvertisementManifest& (NWSyncAdvertisementManifest::*_990)(NWSyncAdvertisementManifest&&) = &NWSyncAdvertisementManifest::operator=;
extern "C" { void NWSyncAdvertisementManifest__NWSyncAdvertisementManifest(NWSyncAdvertisementManifest* __instance) { delete __instance; } };
extern "C" { void NWSyncAdvertisementManifest_NWSyncAdvertisementManifest(void* __instance) { ::new (__instance) NWSyncAdvertisementManifest(); } }
extern "C" { void NWSyncAdvertisement_NWSyncAdvertisement___1__S_NWSyncAdvertisement(void* __instance, const NWSyncAdvertisement& _0) { ::new (__instance) NWSyncAdvertisement(_0); } }
NWSyncAdvertisement& (NWSyncAdvertisement::*_991)(NWSyncAdvertisement&&) = &NWSyncAdvertisement::operator=;
extern "C" { void NWSyncAdvertisement__NWSyncAdvertisement(NWSyncAdvertisement* __instance) { delete __instance; } };
extern "C" { void NWSyncAdvertisement_NWSyncAdvertisement(void* __instance) { ::new (__instance) NWSyncAdvertisement(); } }
extern "C" { void CNWActionNode_CNWActionNode(void* __instance) { ::new (__instance) CNWActionNode(); } }
extern "C" { void CNWActionNode_CNWActionNode___1__S_CNWActionNode(void* __instance, const CNWActionNode& _0) { ::new (__instance) CNWActionNode(_0); } }
CNWActionNode& (CNWActionNode::*_992)(CNWActionNode&&) = &CNWActionNode::operator=;
CNWAmbientSound& (CNWAmbientSound::*_993)(CNWAmbientSound&&) = &CNWAmbientSound::operator=;
extern "C" { void CNWAmbientSound_CNWAmbientSound(void* __instance) { ::new (__instance) CNWAmbientSound(); } }
extern "C" { void CNWAmbientSound_CNWAmbientSound___1__S_CNWAmbientSound(void* __instance, const CNWAmbientSound& _0) { ::new (__instance) CNWAmbientSound(_0); } }
CNWAnimBase& (CNWAnimBase::*_994)(const CNWAnimBase&) = &CNWAnimBase::operator=;
extern "C" { void CNWAnimBase_CNWAnimBase___1__S_CNWAnimBase(void* __instance, const CNWAnimBase& _0) { ::new (__instance) CNWAnimBase(_0); } }
CNWArea& (CNWArea::*_995)(const CNWArea&) = &CNWArea::operator=;
extern "C" { void CNWArea_CNWArea___1__S_CNWArea(void* __instance, const CNWArea& _0) { ::new (__instance) CNWArea(_0); } }
CNWBaseItem& (CNWBaseItem::*_996)(const CNWBaseItem&) = &CNWBaseItem::operator=;
extern "C" { void CNWBaseItem_CNWBaseItem___1__S_CNWBaseItem(void* __instance, const CNWBaseItem& _0) { ::new (__instance) CNWBaseItem(_0); } }
extern "C" { void CNWBaseItemArray_CNWBaseItemArray___1__S_CNWBaseItemArray(void* __instance, const CNWBaseItemArray& _0) { ::new (__instance) CNWBaseItemArray(_0); } }
CNWBaseItemArray& (CNWBaseItemArray::*_997)(const CNWBaseItemArray&) = &CNWBaseItemArray::operator=;
extern "C" { void CNWCCMessageData_CNWCCMessageData___1__S_CNWCCMessageData(void* __instance, const CNWCCMessageData& _0) { ::new (__instance) CNWCCMessageData(_0); } }
CNWCCMessageData& (CNWCCMessageData::*_998)(const CNWCCMessageData&) = &CNWCCMessageData::operator=;
extern "C" { void CNWClass_CNWClass___1__S_CNWClass(void* __instance, const CNWClass& _0) { ::new (__instance) CNWClass(_0); } }
CNWClass& (CNWClass::*_999)(const CNWClass&) = &CNWClass::operator=;
extern "C" { void CNWClass_Feat_CNWClass_Feat(void* __instance) { ::new (__instance) CNWClass_Feat(); } }
extern "C" { void CNWClass_Feat_CNWClass_Feat___1__S_CNWClass_Feat(void* __instance, const CNWClass_Feat& _0) { ::new (__instance) CNWClass_Feat(_0); } }
CNWClass_Feat& (CNWClass_Feat::*_1000)(CNWClass_Feat&&) = &CNWClass_Feat::operator=;
extern "C" { void CNWClass_Skill_CNWClass_Skill(void* __instance) { ::new (__instance) CNWClass_Skill(); } }
extern "C" { void CNWClass_Skill_CNWClass_Skill___1__S_CNWClass_Skill(void* __instance, const CNWClass_Skill& _0) { ::new (__instance) CNWClass_Skill(_0); } }
CNWClass_Skill& (CNWClass_Skill::*_1001)(CNWClass_Skill&&) = &CNWClass_Skill::operator=;
extern "C" { void CNWCreatureStatsUpdate_CNWCreatureStatsUpdate___1__S_CNWCreatureStatsUpdate(void* __instance, const CNWCreatureStatsUpdate& _0) { ::new (__instance) CNWCreatureStatsUpdate(_0); } }
CNWCreatureStatsUpdate& (CNWCreatureStatsUpdate::*_1002)(const CNWCreatureStatsUpdate&) = &CNWCreatureStatsUpdate::operator=;
CNWDomain& (CNWDomain::*_1003)(const CNWDomain&) = &CNWDomain::operator=;
extern "C" { void CNWDomain_CNWDomain___1__S_CNWDomain(void* __instance, const CNWDomain& _0) { ::new (__instance) CNWDomain(_0); } }
extern "C" { void CNWDoorSurfaceMesh_CNWDoorSurfaceMesh___1__S_CNWDoorSurfaceMesh(void* __instance, const CNWDoorSurfaceMesh& _0) { ::new (__instance) CNWDoorSurfaceMesh(_0); } }
CNWDoorSurfaceMesh& (CNWDoorSurfaceMesh::*_1004)(const CNWDoorSurfaceMesh&) = &CNWDoorSurfaceMesh::operator=;
extern "C" { void CResDWK_CResDWK___1__S_CResDWK(void* __instance, const CResDWK& _0) { ::new (__instance) CResDWK(_0); } }
CResDWK& (CResDWK::*_1005)(const CResDWK&) = &CResDWK::operator=;
CNWFeat& (CNWFeat::*_1006)(const CNWFeat&) = &CNWFeat::operator=;
extern "C" { void CNWFeat_CNWFeat___1__S_CNWFeat(void* __instance, const CNWFeat& _0) { ::new (__instance) CNWFeat(_0); } }
extern "C" { void CNWGridSearchPath_CNWGridSearchPath(void* __instance) { ::new (__instance) CNWGridSearchPath(); } }
extern "C" { void CNWGridSearchPath_CNWGridSearchPath___1__S_CNWGridSearchPath(void* __instance, const CNWGridSearchPath& _0) { ::new (__instance) CNWGridSearchPath(_0); } }
CNWGridSearchPath& (CNWGridSearchPath::*_1007)(CNWGridSearchPath&&) = &CNWGridSearchPath::operator=;
CNWItem& (CNWItem::*_1008)(const CNWItem&) = &CNWItem::operator=;
extern "C" { void CNWItem_CNWItem___1__S_CNWItem(void* __instance, const CNWItem& _0) { ::new (__instance) CNWItem(_0); } }
extern "C" { void CNWItemProperty_CNWItemProperty___1__S_CNWItemProperty(void* __instance, const CNWItemProperty& _0) { ::new (__instance) CNWItemProperty(_0); } }
CNWItemProperty& (CNWItemProperty::*_1009)(CNWItemProperty&&) = &CNWItemProperty::operator=;
extern "C" { void CNWItemProperty__CNWItemProperty(CNWItemProperty* __instance) { delete __instance; } };
extern "C" { void CNWItemProperty_CNWItemProperty(void* __instance) { ::new (__instance) CNWItemProperty(); } }
extern "C" { void CNWLevelStats_CNWLevelStats___1__S_CNWLevelStats(void* __instance, const CNWLevelStats& _0) { ::new (__instance) CNWLevelStats(_0); } }
CNWLevelStats& (CNWLevelStats::*_1010)(const CNWLevelStats&) = &CNWLevelStats::operator=;
CNWMessage& (CNWMessage::*_1011)(const CNWMessage&) = &CNWMessage::operator=;
extern "C" { void CNWMessage_CNWMessage___1__S_CNWMessage(void* __instance, const CNWMessage& _0) { ::new (__instance) CNWMessage(_0); } }
extern "C" { void CNWNameGen_CNWNameGen___1__S_CNWNameGen(void* __instance, const CNWNameGen& _0) { ::new (__instance) CNWNameGen(_0); } }
CNWNameGen& (CNWNameGen::*_1012)(const CNWNameGen&) = &CNWNameGen::operator=;
extern "C" { void CResLTR_CResLTR___1__S_CResLTR(void* __instance, const CResLTR& _0) { ::new (__instance) CResLTR(_0); } }
CResLTR& (CResLTR::*_1013)(const CResLTR&) = &CResLTR::operator=;
extern "C" { void CNWPlaceableSurfaceMesh_CNWPlaceableSurfaceMesh___1__S_CNWPlaceableSurfaceMesh(void* __instance, const CNWPlaceableSurfaceMesh& _0) { ::new (__instance) CNWPlaceableSurfaceMesh(_0); } }
CNWPlaceableSurfaceMesh& (CNWPlaceableSurfaceMesh::*_1014)(const CNWPlaceableSurfaceMesh&) = &CNWPlaceableSurfaceMesh::operator=;
extern "C" { void CResPWK_CResPWK___1__S_CResPWK(void* __instance, const CResPWK& _0) { ::new (__instance) CResPWK(_0); } }
CResPWK& (CResPWK::*_1015)(const CResPWK&) = &CResPWK::operator=;
extern "C" { void CNWPlaceMeshManager_CNWPlaceMeshManager___1__S_CNWPlaceMeshManager(void* __instance, const CNWPlaceMeshManager& _0) { ::new (__instance) CNWPlaceMeshManager(_0); } }
CNWPlaceMeshManager& (CNWPlaceMeshManager::*_1016)(const CNWPlaceMeshManager&) = &CNWPlaceMeshManager::operator=;
extern "C" { void CNWRace_CNWRace___1__S_CNWRace(void* __instance, const CNWRace& _0) { ::new (__instance) CNWRace(_0); } }
CNWRace& (CNWRace::*_1017)(const CNWRace&) = &CNWRace::operator=;
extern "C" { void CNWRules_CNWRules___1__S_CNWRules(void* __instance, const CNWRules& _0) { ::new (__instance) CNWRules(_0); } }
CNWRules& (CNWRules::*_1018)(const CNWRules&) = &CNWRules::operator=;
CNWSAmbientSound& (CNWSAmbientSound::*_1019)(const CNWSAmbientSound&) = &CNWSAmbientSound::operator=;
extern "C" { void CNWSAmbientSound_CNWSAmbientSound___1__S_CNWSAmbientSound(void* __instance, const CNWSAmbientSound& _0) { ::new (__instance) CNWSAmbientSound(_0); } }
extern "C" { void CNWSAnimBase_CNWSAnimBase___1__S_CNWSAnimBase(void* __instance, const CNWSAnimBase& _0) { ::new (__instance) CNWSAnimBase(_0); } }
CNWSAnimBase& (CNWSAnimBase::*_1020)(const CNWSAnimBase&) = &CNWSAnimBase::operator=;
extern "C" { void CNWSArea_CNWSArea___1__S_CNWSArea(void* __instance, const CNWSArea& _0) { ::new (__instance) CNWSArea(_0); } }
CNWSArea& (CNWSArea::*_1021)(const CNWSArea&) = &CNWSArea::operator=;
extern "C" { void CScriptLocation_CScriptLocation(void* __instance) { ::new (__instance) CScriptLocation(); } }
extern "C" { void CScriptLocation_CScriptLocation___1__S_CScriptLocation(void* __instance, const CScriptLocation& _0) { ::new (__instance) CScriptLocation(_0); } }
CScriptLocation& (CScriptLocation::*_1022)(CScriptLocation&&) = &CScriptLocation::operator=;
bool (CNWSScriptVar::*_1023)() const = &CNWSScriptVar::HasInt;
bool (CNWSScriptVar::*_1024)() const = &CNWSScriptVar::HasFloat;
bool (CNWSScriptVar::*_1025)() const = &CNWSScriptVar::HasObject;
bool (CNWSScriptVar::*_1026)() const = &CNWSScriptVar::HasString;
bool (CNWSScriptVar::*_1027)() const = &CNWSScriptVar::HasLocation;
extern "C" { void CNWSScriptVar__CNWSScriptVar(CNWSScriptVar* __instance) { delete __instance; } };
extern "C" { void CNWSScriptVarTable_CNWSScriptVarTable___1__S_CNWSScriptVarTable(void* __instance, const CNWSScriptVarTable& _0) { ::new (__instance) CNWSScriptVarTable(_0); } }
CNWSScriptVarTable& (CNWSScriptVarTable::*_1028)(CNWSScriptVarTable&&) = &CNWSScriptVarTable::operator=;
extern "C" { void CNWSScriptVarTable__CNWSScriptVarTable(CNWSScriptVarTable* __instance) { delete __instance; } };
extern "C" { void CNWSScriptVarTable_CNWSScriptVarTable(void* __instance) { ::new (__instance) CNWSScriptVarTable(); } }
extern "C" { void CNWSUUID_CNWSUUID___1__S_CNWSUUID(void* __instance, const CNWSUUID& _0) { ::new (__instance) CNWSUUID(_0); } }
CNWSUUID& (CNWSUUID::*_1029)(const CNWSUUID&) = &CNWSUUID::operator=;
extern "C" { void CResGFF_CResGFF___1__S_CResGFF(void* __instance, const CResGFF& _0) { ::new (__instance) CResGFF(_0); } }
CResGFF& (CResGFF::*_1030)(const CResGFF&) = &CResGFF::operator=;
extern "C" { void CResARE_CResARE___1__S_CResARE(void* __instance, const CResARE& _0) { ::new (__instance) CResARE(_0); } }
CResARE& (CResARE::*_1031)(CResARE&&) = &CResARE::operator=;
extern "C" { void CResARE_CResARE(void* __instance) { ::new (__instance) CResARE(); } }
extern "C" { void NWAREAEXPANSION_NWAREAEXPANSION___1__S_NWAREAEXPANSION(void* __instance, const NWAREAEXPANSION& _0) { ::new (__instance) NWAREAEXPANSION(_0); } }
NWAREAEXPANSION& (NWAREAEXPANSION::*_1032)(NWAREAEXPANSION&&) = &NWAREAEXPANSION::operator=;
extern "C" { void NWAREAEXPANSION__NWAREAEXPANSION(NWAREAEXPANSION* __instance) { delete __instance; } };
extern "C" { void NWAREAEXPANSION_NWAREAEXPANSION(void* __instance) { ::new (__instance) NWAREAEXPANSION(); } }
extern "C" { void CNWSAreaGridPoint_CNWSAreaGridPoint(void* __instance) { ::new (__instance) CNWSAreaGridPoint(); } }
extern "C" { void CNWSAreaGridPoint_CNWSAreaGridPoint___1__S_CNWSAreaGridPoint(void* __instance, const CNWSAreaGridPoint& _0) { ::new (__instance) CNWSAreaGridPoint(_0); } }
CNWSAreaGridPoint& (CNWSAreaGridPoint::*_1033)(CNWSAreaGridPoint&&) = &CNWSAreaGridPoint::operator=;
extern "C" { void CNWSAreaGridSuccessors_CNWSAreaGridSuccessors(void* __instance) { ::new (__instance) CNWSAreaGridSuccessors(); } }
extern "C" { void CNWSAreaGridSuccessors_CNWSAreaGridSuccessors___1__S_CNWSAreaGridSuccessors(void* __instance, const CNWSAreaGridSuccessors& _0) { ::new (__instance) CNWSAreaGridSuccessors(_0); } }
CNWSAreaGridSuccessors& (CNWSAreaGridSuccessors::*_1034)(CNWSAreaGridSuccessors&&) = &CNWSAreaGridSuccessors::operator=;
extern "C" { void CNWSAreaGridTransTableEntry_CNWSAreaGridTransTableEntry(void* __instance) { ::new (__instance) CNWSAreaGridTransTableEntry(); } }
extern "C" { void CNWSAreaGridTransTableEntry_CNWSAreaGridTransTableEntry___1__S_CNWSAreaGridTransTableEntry(void* __instance, const CNWSAreaGridTransTableEntry& _0) { ::new (__instance) CNWSAreaGridTransTableEntry(_0); } }
CNWSAreaGridTransTableEntry& (CNWSAreaGridTransTableEntry::*_1035)(CNWSAreaGridTransTableEntry&&) = &CNWSAreaGridTransTableEntry::operator=;
extern "C" { void CNWSAreaInterTileSuccessors_CNWSAreaInterTileSuccessors(void* __instance) { ::new (__instance) CNWSAreaInterTileSuccessors(); } }
extern "C" { void CNWSAreaInterTileSuccessors_CNWSAreaInterTileSuccessors___1__S_CNWSAreaInterTileSuccessors(void* __instance, const CNWSAreaInterTileSuccessors& _0) { ::new (__instance) CNWSAreaInterTileSuccessors(_0); } }
CNWSAreaInterTileSuccessors& (CNWSAreaInterTileSuccessors::*_1036)(CNWSAreaInterTileSuccessors&&) = &CNWSAreaInterTileSuccessors::operator=;
extern "C" { void CNWSAreaOfEffectObject_CNWSAreaOfEffectObject___1__S_CNWSAreaOfEffectObject(void* __instance, const CNWSAreaOfEffectObject& _0) { ::new (__instance) CNWSAreaOfEffectObject(_0); } }
CNWSAreaOfEffectObject& (CNWSAreaOfEffectObject::*_1037)(const CNWSAreaOfEffectObject&) = &CNWSAreaOfEffectObject::operator=;
extern "C" { void CNWSObjectActionNode_CNWSObjectActionNode___1__S_CNWSObjectActionNode(void* __instance, const CNWSObjectActionNode& _0) { ::new (__instance) CNWSObjectActionNode(_0); } }
CNWSObjectActionNode& (CNWSObjectActionNode::*_1038)(const CNWSObjectActionNode&) = &CNWSObjectActionNode::operator=;
extern "C" { void CNWSTransition_CNWSTransition___1__S_CNWSTransition(void* __instance, const CNWSTransition& _0) { ::new (__instance) CNWSTransition(_0); } }
CNWSTransition& (CNWSTransition::*_1039)(CNWSTransition&&) = &CNWSTransition::operator=;
extern "C" { void CNWSTransition__CNWSTransition(CNWSTransition* __instance) { delete __instance; } };
extern "C" { void CNWSTransition_CNWSTransition(void* __instance) { ::new (__instance) CNWSTransition(); } }
extern "C" { void CNWSObject_CNWSObject___1__S_CNWSObject(void* __instance, const CNWSObject& _0) { ::new (__instance) CNWSObject(_0); } }
CNWSObject& (CNWSObject::*_1040)(const CNWSObject&) = &CNWSObject::operator=;
extern "C" { void CNWSBarter_CNWSBarter___1__S_CNWSBarter(void* __instance, const CNWSBarter& _0) { ::new (__instance) CNWSBarter(_0); } }
CNWSBarter& (CNWSBarter::*_1041)(const CNWSBarter&) = &CNWSBarter::operator=;
CNWSClient& (CNWSClient::*_1042)(const CNWSClient&) = &CNWSClient::operator=;
extern "C" { void CNWSClient_CNWSClient___1__S_CNWSClient(void* __instance, const CNWSClient& _0) { ::new (__instance) CNWSClient(_0); } }
extern "C" { void CNWSCombatAttackData_CNWSCombatAttackData___1__S_CNWSCombatAttackData(void* __instance, const CNWSCombatAttackData& _0) { ::new (__instance) CNWSCombatAttackData(_0); } }
CNWSCombatAttackData& (CNWSCombatAttackData::*_1043)(const CNWSCombatAttackData&) = &CNWSCombatAttackData::operator=;
extern "C" { void CNWSCombatRound_CNWSCombatRound___1__S_CNWSCombatRound(void* __instance, const CNWSCombatRound& _0) { ::new (__instance) CNWSCombatRound(_0); } }
CNWSCombatRound& (CNWSCombatRound::*_1044)(const CNWSCombatRound&) = &CNWSCombatRound::operator=;
extern "C" { void CNWSCombatRoundAction_CNWSCombatRoundAction___1__S_CNWSCombatRoundAction(void* __instance, const CNWSCombatRoundAction& _0) { ::new (__instance) CNWSCombatRoundAction(_0); } }
CNWSCombatRoundAction& (CNWSCombatRoundAction::*_1045)(const CNWSCombatRoundAction&) = &CNWSCombatRoundAction::operator=;
extern "C" { void CNWSCreature_CNWSCreature___1__S_CNWSCreature(void* __instance, const CNWSCreature& _0) { ::new (__instance) CNWSCreature(_0); } }
CNWSCreature& (CNWSCreature::*_1046)(const CNWSCreature&) = &CNWSCreature::operator=;
extern "C" { void CNWSCreatureAppearanceInfo_CNWSCreatureAppearanceInfo___1__S_CNWSCreatureAppearanceInfo(void* __instance, const CNWSCreatureAppearanceInfo& _0) { ::new (__instance) CNWSCreatureAppearanceInfo(_0); } }
CNWSCreatureAppearanceInfo& (CNWSCreatureAppearanceInfo::*_1047)(CNWSCreatureAppearanceInfo&&) = &CNWSCreatureAppearanceInfo::operator=;
extern "C" { void CNWSCreatureAppearanceInfo_CNWSCreatureAppearanceInfo(void* __instance) { ::new (__instance) CNWSCreatureAppearanceInfo(); } }
extern "C" { void CNWSInvitationDetails_CNWSInvitationDetails(void* __instance) { ::new (__instance) CNWSInvitationDetails(); } }
extern "C" { void CNWSInvitationDetails_CNWSInvitationDetails___1__S_CNWSInvitationDetails(void* __instance, const CNWSInvitationDetails& _0) { ::new (__instance) CNWSInvitationDetails(_0); } }
CNWSInvitationDetails& (CNWSInvitationDetails::*_1048)(CNWSInvitationDetails&&) = &CNWSInvitationDetails::operator=;
extern "C" { void CNWSPVPEntry_CNWSPVPEntry(void* __instance) { ::new (__instance) CNWSPVPEntry(); } }
extern "C" { void CNWSPVPEntry_CNWSPVPEntry___1__S_CNWSPVPEntry(void* __instance, const CNWSPVPEntry& _0) { ::new (__instance) CNWSPVPEntry(_0); } }
CNWSPVPEntry& (CNWSPVPEntry::*_1049)(CNWSPVPEntry&&) = &CNWSPVPEntry::operator=;
extern "C" { void CNWSPersonalReputation_CNWSPersonalReputation(void* __instance) { ::new (__instance) CNWSPersonalReputation(); } }
extern "C" { void CNWSPersonalReputation_CNWSPersonalReputation___1__S_CNWSPersonalReputation(void* __instance, const CNWSPersonalReputation& _0) { ::new (__instance) CNWSPersonalReputation(_0); } }
CNWSPersonalReputation& (CNWSPersonalReputation::*_1050)(CNWSPersonalReputation&&) = &CNWSPersonalReputation::operator=;
extern "C" { void CNWSCreatureStats_CNWSCreatureStats___1__S_CNWSCreatureStats(void* __instance, const CNWSCreatureStats& _0) { ::new (__instance) CNWSCreatureStats(_0); } }
CNWSCreatureStats& (CNWSCreatureStats::*_1051)(const CNWSCreatureStats&) = &CNWSCreatureStats::operator=;
extern "C" { void CNWSCreatureStats_ClassInfo_CNWSCreatureStats_ClassInfo___1__S_CNWSCreatureStats_ClassInfo(void* __instance, const CNWSCreatureStats_ClassInfo& _0) { ::new (__instance) CNWSCreatureStats_ClassInfo(_0); } }
CNWSCreatureStats_ClassInfo& (CNWSCreatureStats_ClassInfo::*_1052)(const CNWSCreatureStats_ClassInfo&) = &CNWSCreatureStats_ClassInfo::operator=;
extern "C" { void CNWSStats_SpellLikeAbility_CNWSStats_SpellLikeAbility___1__S_CNWSStats_SpellLikeAbility(void* __instance, const CNWSStats_SpellLikeAbility& _0) { ::new (__instance) CNWSStats_SpellLikeAbility(_0); } }
CNWSStats_SpellLikeAbility& (CNWSStats_SpellLikeAbility::*_1053)(CNWSStats_SpellLikeAbility&&) = &CNWSStats_SpellLikeAbility::operator=;
extern "C" { void CNWSCreRestorePolymorphData_CNWSCreRestorePolymorphData(void* __instance) { ::new (__instance) CNWSCreRestorePolymorphData(); } }
extern "C" { void CNWSCreRestorePolymorphData_CNWSCreRestorePolymorphData___1__S_CNWSCreRestorePolymorphData(void* __instance, const CNWSCreRestorePolymorphData& _0) { ::new (__instance) CNWSCreRestorePolymorphData(_0); } }
CNWSCreRestorePolymorphData& (CNWSCreRestorePolymorphData::*_1054)(CNWSCreRestorePolymorphData&&) = &CNWSCreRestorePolymorphData::operator=;
extern "C" { void CNWSDialog_CNWSDialog___1__S_CNWSDialog(void* __instance, const CNWSDialog& _0) { ::new (__instance) CNWSDialog(_0); } }
CNWSDialog& (CNWSDialog::*_1055)(const CNWSDialog&) = &CNWSDialog::operator=;
extern "C" { void CNWSDialogPlayer_CNWSDialogPlayer(void* __instance) { ::new (__instance) CNWSDialogPlayer(); } }
extern "C" { void CNWSDialogPlayer_CNWSDialogPlayer___1__S_CNWSDialogPlayer(void* __instance, const CNWSDialogPlayer& _0) { ::new (__instance) CNWSDialogPlayer(_0); } }
CNWSDialogPlayer& (CNWSDialogPlayer::*_1056)(CNWSDialogPlayer&&) = &CNWSDialogPlayer::operator=;
extern "C" { void CNWSDialogEntry_CNWSDialogEntry___1__S_CNWSDialogEntry(void* __instance, const CNWSDialogEntry& _0) { ::new (__instance) CNWSDialogEntry(_0); } }
CNWSDialogEntry& (CNWSDialogEntry::*_1057)(CNWSDialogEntry&&) = &CNWSDialogEntry::operator=;
extern "C" { void CNWSDialogEntry__CNWSDialogEntry(CNWSDialogEntry* __instance) { delete __instance; } };
extern "C" { void CNWSDialogEntry_CNWSDialogEntry(void* __instance) { ::new (__instance) CNWSDialogEntry(); } }
extern "C" { void ScriptParam_ScriptParam___1__S_ScriptParam(void* __instance, const ScriptParam& _0) { ::new (__instance) ScriptParam(_0); } }
ScriptParam& (ScriptParam::*_1058)(ScriptParam&&) = &ScriptParam::operator=;
extern "C" { void ScriptParam__ScriptParam(ScriptParam* __instance) { delete __instance; } };
extern "C" { void ScriptParam_ScriptParam(void* __instance) { ::new (__instance) ScriptParam(); } }
extern "C" { void CNWSDialogLinkEntry_CNWSDialogLinkEntry___1__S_CNWSDialogLinkEntry(void* __instance, const CNWSDialogLinkEntry& _0) { ::new (__instance) CNWSDialogLinkEntry(_0); } }
CNWSDialogLinkEntry& (CNWSDialogLinkEntry::*_1059)(CNWSDialogLinkEntry&&) = &CNWSDialogLinkEntry::operator=;
extern "C" { void CNWSDialogLinkEntry__CNWSDialogLinkEntry(CNWSDialogLinkEntry* __instance) { delete __instance; } };
extern "C" { void CNWSDialogLinkEntry_CNWSDialogLinkEntry(void* __instance) { ::new (__instance) CNWSDialogLinkEntry(); } }
extern "C" { void CNWSDialogLinkReply_CNWSDialogLinkReply___1__S_CNWSDialogLinkReply(void* __instance, const CNWSDialogLinkReply& _0) { ::new (__instance) CNWSDialogLinkReply(_0); } }
CNWSDialogLinkReply& (CNWSDialogLinkReply::*_1060)(CNWSDialogLinkReply&&) = &CNWSDialogLinkReply::operator=;
extern "C" { void CNWSDialogLinkReply__CNWSDialogLinkReply(CNWSDialogLinkReply* __instance) { delete __instance; } };
extern "C" { void CNWSDialogLinkReply_CNWSDialogLinkReply(void* __instance) { ::new (__instance) CNWSDialogLinkReply(); } }
extern "C" { void CNWSDialogReply_CNWSDialogReply___1__S_CNWSDialogReply(void* __instance, const CNWSDialogReply& _0) { ::new (__instance) CNWSDialogReply(_0); } }
CNWSDialogReply& (CNWSDialogReply::*_1061)(CNWSDialogReply&&) = &CNWSDialogReply::operator=;
extern "C" { void CNWSDialogReply__CNWSDialogReply(CNWSDialogReply* __instance) { delete __instance; } };
extern "C" { void CNWSDialogReply_CNWSDialogReply(void* __instance) { ::new (__instance) CNWSDialogReply(); } }
extern "C" { void CNWSDialogSpeaker_CNWSDialogSpeaker___1__S_CNWSDialogSpeaker(void* __instance, const CNWSDialogSpeaker& _0) { ::new (__instance) CNWSDialogSpeaker(_0); } }
CNWSDialogSpeaker& (CNWSDialogSpeaker::*_1062)(CNWSDialogSpeaker&&) = &CNWSDialogSpeaker::operator=;
extern "C" { void CNWSDialogSpeaker__CNWSDialogSpeaker(CNWSDialogSpeaker* __instance) { delete __instance; } };
extern "C" { void CNWSDialogSpeaker_CNWSDialogSpeaker(void* __instance) { ::new (__instance) CNWSDialogSpeaker(); } }
extern "C" { void CNWSDoor_CNWSDoor___1__S_CNWSDoor(void* __instance, const CNWSDoor& _0) { ::new (__instance) CNWSDoor(_0); } }
CNWSDoor& (CNWSDoor::*_1063)(const CNWSDoor&) = &CNWSDoor::operator=;
extern "C" { void CNWSEffectListHandler_CNWSEffectListHandler___1__S_CNWSEffectListHandler(void* __instance, const CNWSEffectListHandler& _0) { ::new (__instance) CNWSEffectListHandler(_0); } }
CNWSEffectListHandler& (CNWSEffectListHandler::*_1064)(const CNWSEffectListHandler&) = &CNWSEffectListHandler::operator=;
extern "C" { void CNWSEffectListHandler_CNWSEffectListHandler(void* __instance) { ::new (__instance) CNWSEffectListHandler(); } }
extern "C" { void CNWSEncounter_CNWSEncounter___1__S_CNWSEncounter(void* __instance, const CNWSEncounter& _0) { ::new (__instance) CNWSEncounter(_0); } }
CNWSEncounter& (CNWSEncounter::*_1065)(const CNWSEncounter&) = &CNWSEncounter::operator=;
extern "C" { void CNWSExpression_CNWSExpression___1__S_CNWSExpression(void* __instance, const CNWSExpression& _0) { ::new (__instance) CNWSExpression(_0); } }
CNWSExpression& (CNWSExpression::*_1066)(const CNWSExpression&) = &CNWSExpression::operator=;
extern "C" { void CNWSExpressionList_CNWSExpressionList___1__S_CNWSExpressionList(void* __instance, const CNWSExpressionList& _0) { ::new (__instance) CNWSExpressionList(_0); } }
CNWSExpressionList& (CNWSExpressionList::*_1067)(const CNWSExpressionList&) = &CNWSExpressionList::operator=;
extern "C" { void CNWSExpressionNode_CNWSExpressionNode___1__S_CNWSExpressionNode(void* __instance, const CNWSExpressionNode& _0) { ::new (__instance) CNWSExpressionNode(_0); } }
CNWSExpressionNode& (CNWSExpressionNode::*_1068)(const CNWSExpressionNode&) = &CNWSExpressionNode::operator=;
extern "C" { void CNWSFaction_CNWSFaction___1__S_CNWSFaction(void* __instance, const CNWSFaction& _0) { ::new (__instance) CNWSFaction(_0); } }
CNWSFaction& (CNWSFaction::*_1069)(const CNWSFaction&) = &CNWSFaction::operator=;
extern "C" { void CNWSForcedAction_CNWSForcedAction___1__S_CNWSForcedAction(void* __instance, const CNWSForcedAction& _0) { ::new (__instance) CNWSForcedAction(_0); } }
CNWSForcedAction& (CNWSForcedAction::*_1070)(const CNWSForcedAction&) = &CNWSForcedAction::operator=;
CNWSInventory& (CNWSInventory::*_1071)(const CNWSInventory&) = &CNWSInventory::operator=;
extern "C" { void CNWSInventory_CNWSInventory___1__S_CNWSInventory(void* __instance, const CNWSInventory& _0) { ::new (__instance) CNWSInventory(_0); } }
extern "C" { void CNWSItem_CNWSItem___1__S_CNWSItem(void* __instance, const CNWSItem& _0) { ::new (__instance) CNWSItem(_0); } }
CNWSItem& (CNWSItem::*_1072)(const CNWSItem&) = &CNWSItem::operator=;
extern "C" { void CNWSJournal_CNWSJournal___1__S_CNWSJournal(void* __instance, const CNWSJournal& _0) { ::new (__instance) CNWSJournal(_0); } }
CNWSJournal& (CNWSJournal::*_1073)(const CNWSJournal&) = &CNWSJournal::operator=;
extern "C" { void SJournalEntry_SJournalEntry___1__S_SJournalEntry(void* __instance, const SJournalEntry& _0) { ::new (__instance) SJournalEntry(_0); } }
SJournalEntry& (SJournalEntry::*_1074)(SJournalEntry&&) = &SJournalEntry::operator=;
extern "C" { void SJournalEntry__SJournalEntry(SJournalEntry* __instance) { delete __instance; } };
extern "C" { void SJournalEntry_SJournalEntry(void* __instance) { ::new (__instance) SJournalEntry(); } }
extern "C" { void CNWSkill_CNWSkill___1__S_CNWSkill(void* __instance, const CNWSkill& _0) { ::new (__instance) CNWSkill(_0); } }
CNWSkill& (CNWSkill::*_1075)(const CNWSkill&) = &CNWSkill::operator=;
extern "C" { void CNWSMessage_CNWSMessage___1__S_CNWSMessage(void* __instance, const CNWSMessage& _0) { ::new (__instance) CNWSMessage(_0); } }
CNWSMessage& (CNWSMessage::*_1076)(const CNWSMessage&) = &CNWSMessage::operator=;
extern "C" { void CNWSModule_CNWSModule___1__S_CNWSModule(void* __instance, const CNWSModule& _0) { ::new (__instance) CNWSModule(_0); } }
CNWSModule& (CNWSModule::*_1077)(const CNWSModule&) = &CNWSModule::operator=;
extern "C" { void CNWSPlayerTURD_CNWSPlayerTURD___1__S_CNWSPlayerTURD(void* __instance, const CNWSPlayerTURD& _0) { ::new (__instance) CNWSPlayerTURD(_0); } }
CNWSPlayerTURD& (CNWSPlayerTURD::*_1078)(const CNWSPlayerTURD&) = &CNWSPlayerTURD::operator=;
extern "C" { void CNWSTagNode_CNWSTagNode(void* __instance) { ::new (__instance) CNWSTagNode(); } }
extern "C" { void CNWSTagNode_CNWSTagNode___1__S_CNWSTagNode(void* __instance, const CNWSTagNode& _0) { ::new (__instance) CNWSTagNode(_0); } }
CNWSTagNode& (CNWSTagNode::*_1079)(CNWSTagNode&&) = &CNWSTagNode::operator=;
extern "C" { void CResIFO_CResIFO___1__S_CResIFO(void* __instance, const CResIFO& _0) { ::new (__instance) CResIFO(_0); } }
CResIFO& (CResIFO::*_1080)(CResIFO&&) = &CResIFO::operator=;
extern "C" { void CResIFO_CResIFO(void* __instance) { ::new (__instance) CResIFO(); } }
extern "C" { void CWorldJournalEntry_CWorldJournalEntry___1__S_CWorldJournalEntry(void* __instance, const CWorldJournalEntry& _0) { ::new (__instance) CWorldJournalEntry(_0); } }
CWorldJournalEntry& (CWorldJournalEntry::*_1081)(CWorldJournalEntry&&) = &CWorldJournalEntry::operator=;
extern "C" { void CWorldJournalEntry__CWorldJournalEntry(CWorldJournalEntry* __instance) { delete __instance; } };
extern "C" { void CWorldJournalEntry_CWorldJournalEntry(void* __instance) { ::new (__instance) CWorldJournalEntry(); } }
NWMODULECUTSCENE& (NWMODULECUTSCENE::*_1082)(NWMODULECUTSCENE&&) = &NWMODULECUTSCENE::operator=;
extern "C" { void NWMODULECUTSCENE_NWMODULECUTSCENE(void* __instance) { ::new (__instance) NWMODULECUTSCENE(); } }
extern "C" { void NWMODULECUTSCENE_NWMODULECUTSCENE___1__S_NWMODULECUTSCENE(void* __instance, const NWMODULECUTSCENE& _0) { ::new (__instance) NWMODULECUTSCENE(_0); } }
extern "C" { void NWMODULEEXPANSION_NWMODULEEXPANSION___1__S_NWMODULEEXPANSION(void* __instance, const NWMODULEEXPANSION& _0) { ::new (__instance) NWMODULEEXPANSION(_0); } }
NWMODULEEXPANSION& (NWMODULEEXPANSION::*_1083)(NWMODULEEXPANSION&&) = &NWMODULEEXPANSION::operator=;
extern "C" { void NWMODULEEXPANSION__NWMODULEEXPANSION(NWMODULEEXPANSION* __instance) { delete __instance; } };
extern "C" { void NWMODULEEXPANSION_NWMODULEEXPANSION(void* __instance) { ::new (__instance) NWMODULEEXPANSION(); } }
extern "C" { void NWPLAYERLISTITEM_NWPLAYERLISTITEM___1__S_NWPLAYERLISTITEM(void* __instance, const NWPLAYERLISTITEM& _0) { ::new (__instance) NWPLAYERLISTITEM(_0); } }
NWPLAYERLISTITEM& (NWPLAYERLISTITEM::*_1084)(NWPLAYERLISTITEM&&) = &NWPLAYERLISTITEM::operator=;
extern "C" { void NWPLAYERLISTITEM__NWPLAYERLISTITEM(NWPLAYERLISTITEM* __instance) { delete __instance; } };
extern "C" { void NWPLAYERLISTITEM_NWPLAYERLISTITEM(void* __instance) { ::new (__instance) NWPLAYERLISTITEM(); } }
extern "C" { void CNWSObjectEventHandler_CNWSObjectEventHandler___1__S_CNWSObjectEventHandler(void* __instance, const CNWSObjectEventHandler& _0) { ::new (__instance) CNWSObjectEventHandler(_0); } }
CNWSObjectEventHandler& (CNWSObjectEventHandler::*_1085)(CNWSObjectEventHandler&&) = &CNWSObjectEventHandler::operator=;
extern "C" { void CNWSObjectEventHandler__CNWSObjectEventHandler(CNWSObjectEventHandler* __instance) { delete __instance; } };
extern "C" { void CNWSObjectEventHandler_CNWSObjectEventHandler(void* __instance) { ::new (__instance) CNWSObjectEventHandler(); } }
extern "C" { void CNWSpell_CNWSpell___1__S_CNWSpell(void* __instance, const CNWSpell& _0) { ::new (__instance) CNWSpell(_0); } }
CNWSpell& (CNWSpell::*_1086)(const CNWSpell&) = &CNWSpell::operator=;
extern "C" { void CNWSpellArray_CNWSpellArray___1__S_CNWSpellArray(void* __instance, const CNWSpellArray& _0) { ::new (__instance) CNWSpellArray(_0); } }
CNWSpellArray& (CNWSpellArray::*_1087)(const CNWSpellArray&) = &CNWSpellArray::operator=;
extern "C" { void CNWSPlaceable_CNWSPlaceable___1__S_CNWSPlaceable(void* __instance, const CNWSPlaceable& _0) { ::new (__instance) CNWSPlaceable(_0); } }
CNWSPlaceable& (CNWSPlaceable::*_1088)(const CNWSPlaceable&) = &CNWSPlaceable::operator=;
extern "C" { void CNWSPlayer_CNWSPlayer___1__S_CNWSPlayer(void* __instance, const CNWSPlayer& _0) { ::new (__instance) CNWSPlayer(_0); } }
CNWSPlayer& (CNWSPlayer::*_1089)(const CNWSPlayer&) = &CNWSPlayer::operator=;
extern "C" { void CNWSPlayerCharSheetGUI_CNWSPlayerCharSheetGUI(void* __instance) { ::new (__instance) CNWSPlayerCharSheetGUI(); } }
extern "C" { void CNWSPlayerCharSheetGUI_CNWSPlayerCharSheetGUI___1__S_CNWSPlayerCharSheetGUI(void* __instance, const CNWSPlayerCharSheetGUI& _0) { ::new (__instance) CNWSPlayerCharSheetGUI(_0); } }
CNWSPlayerCharSheetGUI& (CNWSPlayerCharSheetGUI::*_1090)(CNWSPlayerCharSheetGUI&&) = &CNWSPlayerCharSheetGUI::operator=;
extern "C" { void CNWSPlayerContainerGUI_CNWSPlayerContainerGUI___1__S_CNWSPlayerContainerGUI(void* __instance, const CNWSPlayerContainerGUI& _0) { ::new (__instance) CNWSPlayerContainerGUI(_0); } }
CNWSPlayerContainerGUI& (CNWSPlayerContainerGUI::*_1091)(CNWSPlayerContainerGUI&&) = &CNWSPlayerContainerGUI::operator=;
extern "C" { void CNWSPlayerInventoryGUI_CNWSPlayerInventoryGUI___1__S_CNWSPlayerInventoryGUI(void* __instance, const CNWSPlayerInventoryGUI& _0) { ::new (__instance) CNWSPlayerInventoryGUI(_0); } }
CNWSPlayerInventoryGUI& (CNWSPlayerInventoryGUI::*_1092)(const CNWSPlayerInventoryGUI&) = &CNWSPlayerInventoryGUI::operator=;
extern "C" { void CNWSPlayerJournalQuest_CNWSPlayerJournalQuest___1__S_CNWSPlayerJournalQuest(void* __instance, const CNWSPlayerJournalQuest& _0) { ::new (__instance) CNWSPlayerJournalQuest(_0); } }
CNWSPlayerJournalQuest& (CNWSPlayerJournalQuest::*_1093)(CNWSPlayerJournalQuest&&) = &CNWSPlayerJournalQuest::operator=;
extern "C" { void CNWSPlayerJournalQuest__CNWSPlayerJournalQuest(CNWSPlayerJournalQuest* __instance) { delete __instance; } };
extern "C" { void CNWSPlayerJournalQuest_CNWSPlayerJournalQuest(void* __instance) { ::new (__instance) CNWSPlayerJournalQuest(); } }
extern "C" { void CNWSPlayerJournalQuestUpdates_CNWSPlayerJournalQuestUpdates___1__S_CNWSPlayerJournalQuestUpdates(void* __instance, const CNWSPlayerJournalQuestUpdates& _0) { ::new (__instance) CNWSPlayerJournalQuestUpdates(_0); } }
CNWSPlayerJournalQuestUpdates& (CNWSPlayerJournalQuestUpdates::*_1094)(CNWSPlayerJournalQuestUpdates&&) = &CNWSPlayerJournalQuestUpdates::operator=;
extern "C" { void CNWSPlayerJournalQuestUpdates__CNWSPlayerJournalQuestUpdates(CNWSPlayerJournalQuestUpdates* __instance) { delete __instance; } };
extern "C" { void CNWSPlayerJournalQuestUpdates_CNWSPlayerJournalQuestUpdates(void* __instance) { ::new (__instance) CNWSPlayerJournalQuestUpdates(); } }
extern "C" { void CNWSPlayerLastUpdateObject_CNWSPlayerLastUpdateObject___1__S_CNWSPlayerLastUpdateObject(void* __instance, const CNWSPlayerLastUpdateObject& _0) { ::new (__instance) CNWSPlayerLastUpdateObject(_0); } }
CNWSPlayerLastUpdateObject& (CNWSPlayerLastUpdateObject::*_1095)(const CNWSPlayerLastUpdateObject&) = &CNWSPlayerLastUpdateObject::operator=;
extern "C" { void CNWSPlayerLUOInventory_CNWSPlayerLUOInventory___1__S_CNWSPlayerLUOInventory(void* __instance, const CNWSPlayerLUOInventory& _0) { ::new (__instance) CNWSPlayerLUOInventory(_0); } }
CNWSPlayerLUOInventory& (CNWSPlayerLUOInventory::*_1096)(const CNWSPlayerLUOInventory&) = &CNWSPlayerLUOInventory::operator=;
extern "C" { void CNWSPlayerLUOInventoryItem_CNWSPlayerLUOInventoryItem(void* __instance) { ::new (__instance) CNWSPlayerLUOInventoryItem(); } }
extern "C" { void CNWSPlayerLUOInventoryItem_CNWSPlayerLUOInventoryItem___1__S_CNWSPlayerLUOInventoryItem(void* __instance, const CNWSPlayerLUOInventoryItem& _0) { ::new (__instance) CNWSPlayerLUOInventoryItem(_0); } }
CNWSPlayerLUOInventoryItem& (CNWSPlayerLUOInventoryItem::*_1097)(CNWSPlayerLUOInventoryItem&&) = &CNWSPlayerLUOInventoryItem::operator=;
extern "C" { void CNWSPlayerLUOQuickbarItemButton_CNWSPlayerLUOQuickbarItemButton(void* __instance) { ::new (__instance) CNWSPlayerLUOQuickbarItemButton(); } }
extern "C" { void CNWSPlayerLUOQuickbarItemButton_CNWSPlayerLUOQuickbarItemButton___1__S_CNWSPlayerLUOQuickbarItemButton(void* __instance, const CNWSPlayerLUOQuickbarItemButton& _0) { ::new (__instance) CNWSPlayerLUOQuickbarItemButton(_0); } }
CNWSPlayerLUOQuickbarItemButton& (CNWSPlayerLUOQuickbarItemButton::*_1098)(CNWSPlayerLUOQuickbarItemButton&&) = &CNWSPlayerLUOQuickbarItemButton::operator=;
extern "C" { void CNWSPlayerLUOSortedObjectList_CNWSPlayerLUOSortedObjectList(void* __instance) { ::new (__instance) CNWSPlayerLUOSortedObjectList(); } }
extern "C" { void CNWSPlayerLUOSortedObjectList_CNWSPlayerLUOSortedObjectList___1__S_CNWSPlayerLUOSortedObjectList(void* __instance, const CNWSPlayerLUOSortedObjectList& _0) { ::new (__instance) CNWSPlayerLUOSortedObjectList(_0); } }
CNWSPlayerLUOSortedObjectList& (CNWSPlayerLUOSortedObjectList::*_1099)(CNWSPlayerLUOSortedObjectList&&) = &CNWSPlayerLUOSortedObjectList::operator=;
extern "C" { void CNWSPlayerStoreGUI_CNWSPlayerStoreGUI___1__S_CNWSPlayerStoreGUI(void* __instance, const CNWSPlayerStoreGUI& _0) { ::new (__instance) CNWSPlayerStoreGUI(_0); } }
CNWSPlayerStoreGUI& (CNWSPlayerStoreGUI::*_1100)(CNWSPlayerStoreGUI&&) = &CNWSPlayerStoreGUI::operator=;
extern "C" { void CNWSPortal_CNWSPortal___1__S_CNWSPortal(void* __instance, const CNWSPortal& _0) { ::new (__instance) CNWSPortal(_0); } }
CNWSPortal& (CNWSPortal::*_1101)(const CNWSPortal&) = &CNWSPortal::operator=;
extern "C" { void CNWSQuickbarButton_CNWSQuickbarButton___1__S_CNWSQuickbarButton(void* __instance, const CNWSQuickbarButton& _0) { ::new (__instance) CNWSQuickbarButton(_0); } }
CNWSQuickbarButton& (CNWSQuickbarButton::*_1102)(CNWSQuickbarButton&&) = &CNWSQuickbarButton::operator=;
extern "C" { void CNWSQuickbarButton__CNWSQuickbarButton(CNWSQuickbarButton* __instance) { delete __instance; } };
extern "C" { void CNWSQuickbarButton_CNWSQuickbarButton(void* __instance) { ::new (__instance) CNWSQuickbarButton(); } }
extern "C" { void CNWSRules_CNWSRules___1__S_CNWSRules(void* __instance, const CNWSRules& _0) { ::new (__instance) CNWSRules(_0); } }
CNWSRules& (CNWSRules::*_1103)(const CNWSRules&) = &CNWSRules::operator=;
CNWSSound& (CNWSSound::*_1104)(const CNWSSound&) = &CNWSSound::operator=;
extern "C" { void CNWSSound_CNWSSound___1__S_CNWSSound(void* __instance, const CNWSSound& _0) { ::new (__instance) CNWSSound(_0); } }
extern "C" { void CNWSSoundObject_CNWSSoundObject___1__S_CNWSSoundObject(void* __instance, const CNWSSoundObject& _0) { ::new (__instance) CNWSSoundObject(_0); } }
CNWSSoundObject& (CNWSSoundObject::*_1105)(const CNWSSoundObject&) = &CNWSSoundObject::operator=;
extern "C" { void CNWSSpellScriptData_CNWSSpellScriptData___1__S_CNWSSpellScriptData(void* __instance, const CNWSSpellScriptData& _0) { ::new (__instance) CNWSSpellScriptData(_0); } }
CNWSSpellScriptData& (CNWSSpellScriptData::*_1106)(CNWSSpellScriptData&&) = &CNWSSpellScriptData::operator=;
extern "C" { void CNWSSpellScriptData__CNWSSpellScriptData(CNWSSpellScriptData* __instance) { delete __instance; } };
extern "C" { void CNWSSpellScriptData_CNWSSpellScriptData(void* __instance) { ::new (__instance) CNWSSpellScriptData(); } }
extern "C" { void CNWSStats_Spell_CNWSStats_Spell___1__S_CNWSStats_Spell(void* __instance, const CNWSStats_Spell& _0) { ::new (__instance) CNWSStats_Spell(_0); } }
CNWSStats_Spell& (CNWSStats_Spell::*_1107)(CNWSStats_Spell&&) = &CNWSStats_Spell::operator=;
extern "C" { void CNWSStore_CNWSStore___1__S_CNWSStore(void* __instance, const CNWSStore& _0) { ::new (__instance) CNWSStore(_0); } }
CNWSStore& (CNWSStore::*_1108)(const CNWSStore&) = &CNWSStore::operator=;
extern "C" { void CNWSSysAdmin_CNWSSysAdmin___1__S_CNWSSysAdmin(void* __instance, const CNWSSysAdmin& _0) { ::new (__instance) CNWSSysAdmin(_0); } }
CNWSSysAdmin& (CNWSSysAdmin::*_1109)(const CNWSSysAdmin&) = &CNWSSysAdmin::operator=;
extern "C" { void CNWSTile_CNWSTile___1__S_CNWSTile(void* __instance, const CNWSTile& _0) { ::new (__instance) CNWSTile(_0); } }
CNWSTile& (CNWSTile::*_1110)(const CNWSTile&) = &CNWSTile::operator=;
CNWTile& (CNWTile::*_1111)(const CNWTile&) = &CNWTile::operator=;
extern "C" { void CNWTile_CNWTile___1__S_CNWTile(void* __instance, const CNWTile& _0) { ::new (__instance) CNWTile(_0); } }
extern "C" { void CNWSTileSet_CNWSTileSet___1__S_CNWSTileSet(void* __instance, const CNWSTileSet& _0) { ::new (__instance) CNWSTileSet(_0); } }
CNWSTileSet& (CNWSTileSet::*_1112)(const CNWSTileSet&) = &CNWSTileSet::operator=;
extern "C" { void CResSET_CResSET___1__S_CResSET(void* __instance, const CResSET& _0) { ::new (__instance) CResSET(_0); } }
CResSET& (CResSET::*_1113)(const CResSET&) = &CResSET::operator=;
extern "C" { void CNWTileSet_CNWTileSet___1__S_CNWTileSet(void* __instance, const CNWTileSet& _0) { ::new (__instance) CNWTileSet(_0); } }
CNWTileSet& (CNWTileSet::*_1114)(const CNWTileSet&) = &CNWTileSet::operator=;
extern "C" { void CNWSTrigger_CNWSTrigger___1__S_CNWSTrigger(void* __instance, const CNWSTrigger& _0) { ::new (__instance) CNWSTrigger(_0); } }
CNWSTrigger& (CNWSTrigger::*_1115)(const CNWSTrigger&) = &CNWSTrigger::operator=;
extern "C" { void CNWSWaypoint_CNWSWaypoint___1__S_CNWSWaypoint(void* __instance, const CNWSWaypoint& _0) { ::new (__instance) CNWSWaypoint(_0); } }
CNWSWaypoint& (CNWSWaypoint::*_1116)(const CNWSWaypoint&) = &CNWSWaypoint::operator=;
extern "C" { void CNWTileData_CNWTileData___1__S_CNWTileData(void* __instance, const CNWTileData& _0) { ::new (__instance) CNWTileData(_0); } }
CNWTileData& (CNWTileData::*_1117)(const CNWTileData&) = &CNWTileData::operator=;
extern "C" { void CNWTilePathNode_CNWTilePathNode(void* __instance) { ::new (__instance) CNWTilePathNode(); } }
extern "C" { void CNWTilePathNode_CNWTilePathNode___1__S_CNWTilePathNode(void* __instance, const CNWTilePathNode& _0) { ::new (__instance) CNWTilePathNode(_0); } }
CNWTilePathNode& (CNWTilePathNode::*_1118)(CNWTilePathNode&&) = &CNWTilePathNode::operator=;
extern "C" { void CNWTileSetManager_CNWTileSetManager___1__S_CNWTileSetManager(void* __instance, const CNWTileSetManager& _0) { ::new (__instance) CNWTileSetManager(_0); } }
CNWTileSetManager& (CNWTileSetManager::*_1119)(const CNWTileSetManager&) = &CNWTileSetManager::operator=;
extern "C" { void CNWTileSurfaceMesh_CNWTileSurfaceMesh___1__S_CNWTileSurfaceMesh(void* __instance, const CNWTileSurfaceMesh& _0) { ::new (__instance) CNWTileSurfaceMesh(_0); } }
CNWTileSurfaceMesh& (CNWTileSurfaceMesh::*_1120)(const CNWTileSurfaceMesh&) = &CNWTileSurfaceMesh::operator=;
extern "C" { void CNWTileSurfaceMeshLocalInfo_CNWTileSurfaceMeshLocalInfo___1__S_CNWTileSurfaceMeshLocalInfo(void* __instance, const CNWTileSurfaceMeshLocalInfo& _0) { ::new (__instance) CNWTileSurfaceMeshLocalInfo(_0); } }
CNWTileSurfaceMeshLocalInfo& (CNWTileSurfaceMeshLocalInfo::*_1121)(CNWTileSurfaceMeshLocalInfo&&) = &CNWTileSurfaceMeshLocalInfo::operator=;
extern "C" { void CNWTileSurfaceMeshLocalInfo_CNWTileSurfaceMeshLocalInfo(void* __instance) { ::new (__instance) CNWTileSurfaceMeshLocalInfo(); } }
extern "C" { void CResWOK_CResWOK___1__S_CResWOK(void* __instance, const CResWOK& _0) { ::new (__instance) CResWOK(_0); } }
CResWOK& (CResWOK::*_1122)(const CResWOK&) = &CResWOK::operator=;
extern "C" { void CNWTileSurfaceMeshAABBNode_CNWTileSurfaceMeshAABBNode(void* __instance) { ::new (__instance) CNWTileSurfaceMeshAABBNode(); } }
extern "C" { void CNWTileSurfaceMeshAABBNode_CNWTileSurfaceMeshAABBNode___1__S_CNWTileSurfaceMeshAABBNode(void* __instance, const CNWTileSurfaceMeshAABBNode& _0) { ::new (__instance) CNWTileSurfaceMeshAABBNode(_0); } }
CNWTileSurfaceMeshAABBNode& (CNWTileSurfaceMeshAABBNode::*_1123)(CNWTileSurfaceMeshAABBNode&&) = &CNWTileSurfaceMeshAABBNode::operator=;
extern "C" { void CNWTileSurfaceMeshHashTableEntry_CNWTileSurfaceMeshHashTableEntry___1__S_CNWTileSurfaceMeshHashTableEntry(void* __instance, const CNWTileSurfaceMeshHashTableEntry& _0) { ::new (__instance) CNWTileSurfaceMeshHashTableEntry(_0); } }
CNWTileSurfaceMeshHashTableEntry& (CNWTileSurfaceMeshHashTableEntry::*_1124)(CNWTileSurfaceMeshHashTableEntry&&) = &CNWTileSurfaceMeshHashTableEntry::operator=;
extern "C" { void CNWTileSurfaceMeshNodeFace_CNWTileSurfaceMeshNodeFace(void* __instance) { ::new (__instance) CNWTileSurfaceMeshNodeFace(); } }
extern "C" { void CNWTileSurfaceMeshNodeFace_CNWTileSurfaceMeshNodeFace___1__S_CNWTileSurfaceMeshNodeFace(void* __instance, const CNWTileSurfaceMeshNodeFace& _0) { ::new (__instance) CNWTileSurfaceMeshNodeFace(_0); } }
CNWTileSurfaceMeshNodeFace& (CNWTileSurfaceMeshNodeFace::*_1125)(CNWTileSurfaceMeshNodeFace&&) = &CNWTileSurfaceMeshNodeFace::operator=;
extern "C" { void CNWTileSurfaceMeshNodeVertex_CNWTileSurfaceMeshNodeVertex(void* __instance) { ::new (__instance) CNWTileSurfaceMeshNodeVertex(); } }
extern "C" { void CNWTileSurfaceMeshNodeVertex_CNWTileSurfaceMeshNodeVertex___1__S_CNWTileSurfaceMeshNodeVertex(void* __instance, const CNWTileSurfaceMeshNodeVertex& _0) { ::new (__instance) CNWTileSurfaceMeshNodeVertex(_0); } }
CNWTileSurfaceMeshNodeVertex& (CNWTileSurfaceMeshNodeVertex::*_1126)(CNWTileSurfaceMeshNodeVertex&&) = &CNWTileSurfaceMeshNodeVertex::operator=;
extern "C" { void CNWTileSurfaceMeshSortSuccessors_CNWTileSurfaceMeshSortSuccessors(void* __instance) { ::new (__instance) CNWTileSurfaceMeshSortSuccessors(); } }
extern "C" { void CNWTileSurfaceMeshSortSuccessors_CNWTileSurfaceMeshSortSuccessors___1__S_CNWTileSurfaceMeshSortSuccessors(void* __instance, const CNWTileSurfaceMeshSortSuccessors& _0) { ::new (__instance) CNWTileSurfaceMeshSortSuccessors(_0); } }
CNWTileSurfaceMeshSortSuccessors& (CNWTileSurfaceMeshSortSuccessors::*_1127)(CNWTileSurfaceMeshSortSuccessors&&) = &CNWTileSurfaceMeshSortSuccessors::operator=;
extern "C" { void CNWVirtualMachineCommands_CNWVirtualMachineCommands___1__S_CNWVirtualMachineCommands(void* __instance, const CNWVirtualMachineCommands& _0) { ::new (__instance) CNWVirtualMachineCommands(_0); } }
CNWVirtualMachineCommands& (CNWVirtualMachineCommands::*_1128)(const CNWVirtualMachineCommands&) = &CNWVirtualMachineCommands::operator=;
extern "C" { void CNWVirtualMachineCommands_CNWVirtualMachineCommands(void* __instance) { ::new (__instance) CNWVirtualMachineCommands(); } }
CVirtualMachineCmdImplementer& (CVirtualMachineCmdImplementer::*_1129)(const CVirtualMachineCmdImplementer&) = &CVirtualMachineCmdImplementer::operator=;
extern "C" { void CVirtualMachineCmdImplementer_CVirtualMachineCmdImplementer___1__S_CVirtualMachineCmdImplementer(void* __instance, const CVirtualMachineCmdImplementer& _0) { ::new (__instance) CVirtualMachineCmdImplementer(_0); } }
extern "C" { void CVirtualMachineCmdImplementer_CVirtualMachineCmdImplementer(void* __instance) { ::new (__instance) CVirtualMachineCmdImplementer(); } }
extern "C" { void CNWVisibilityNode_CNWVisibilityNode(void* __instance) { ::new (__instance) CNWVisibilityNode(); } }
extern "C" { void CNWVisibilityNode_CNWVisibilityNode___1__S_CNWVisibilityNode(void* __instance, const CNWVisibilityNode& _0) { ::new (__instance) CNWVisibilityNode(_0); } }
CNWVisibilityNode& (CNWVisibilityNode::*_1130)(CNWVisibilityNode&&) = &CNWVisibilityNode::operator=;
extern "C" { void CObjectLookupTable_CObjectLookupTable___1__S_CObjectLookupTable(void* __instance, const CObjectLookupTable& _0) { ::new (__instance) CObjectLookupTable(_0); } }
CObjectLookupTable& (CObjectLookupTable::*_1131)(const CObjectLookupTable&) = &CObjectLookupTable::operator=;
extern "C" { void CObjectTableManager_CObjectTableManager___1__S_CObjectTableManager(void* __instance, const CObjectTableManager& _0) { ::new (__instance) CObjectTableManager(_0); } }
CObjectTableManager& (CObjectTableManager::*_1132)(const CObjectTableManager&) = &CObjectTableManager::operator=;
extern "C" { void CPathfindInfoIntraTileSuccessors_CPathfindInfoIntraTileSuccessors___1__S_CPathfindInfoIntraTileSuccessors(void* __instance, const CPathfindInfoIntraTileSuccessors& _0) { ::new (__instance) CPathfindInfoIntraTileSuccessors(_0); } }
CPathfindInfoIntraTileSuccessors& (CPathfindInfoIntraTileSuccessors::*_1133)(CPathfindInfoIntraTileSuccessors&&) = &CPathfindInfoIntraTileSuccessors::operator=;
extern "C" { void CPathfindInformation_CPathfindInformation___1__S_CPathfindInformation(void* __instance, const CPathfindInformation& _0) { ::new (__instance) CPathfindInformation(_0); } }
CPathfindInformation& (CPathfindInformation::*_1134)(const CPathfindInformation&) = &CPathfindInformation::operator=;
extern "C" { void Vector2_Vector2(void* __instance) { ::new (__instance) Vector2(); } }
extern "C" { void Vector2_Vector2___1__S_Vector2(void* __instance, const Vector2& _0) { ::new (__instance) Vector2(_0); } }
Vector2& (Vector2::*_1135)(Vector2&&) = &Vector2::operator=;
extern "C" { void CPersistantWorldOptions_CPersistantWorldOptions(void* __instance) { ::new (__instance) CPersistantWorldOptions(); } }
extern "C" { void CPersistantWorldOptions_CPersistantWorldOptions___1__S_CPersistantWorldOptions(void* __instance, const CPersistantWorldOptions& _0) { ::new (__instance) CPersistantWorldOptions(_0); } }
CPersistantWorldOptions& (CPersistantWorldOptions::*_1136)(CPersistantWorldOptions&&) = &CPersistantWorldOptions::operator=;
extern "C" { void CPlayOptions_CPlayOptions(void* __instance) { ::new (__instance) CPlayOptions(); } }
extern "C" { void CPlayOptions_CPlayOptions___1__S_CPlayOptions(void* __instance, const CPlayOptions& _0) { ::new (__instance) CPlayOptions(_0); } }
CPlayOptions& (CPlayOptions::*_1137)(CPlayOptions&&) = &CPlayOptions::operator=;
extern "C" { void CResetOption_CResetOption(void* __instance) { ::new (__instance) CResetOption(); } }
extern "C" { void CResetOption_CResetOption___1__S_CResetOption(void* __instance, const CResetOption& _0) { ::new (__instance) CResetOption(_0); } }
CResetOption& (CResetOption::*_1138)(CResetOption&&) = &CResetOption::operator=;
extern "C" { void CResGenericFileHeader_CResGenericFileHeader(void* __instance) { ::new (__instance) CResGenericFileHeader(); } }
extern "C" { void CResGenericFileHeader_CResGenericFileHeader___1__S_CResGenericFileHeader(void* __instance, const CResGenericFileHeader& _0) { ::new (__instance) CResGenericFileHeader(_0); } }
CResGenericFileHeader& (CResGenericFileHeader::*_1139)(CResGenericFileHeader&&) = &CResGenericFileHeader::operator=;
extern "C" { void CResGFFField_CResGFFField(void* __instance) { ::new (__instance) CResGFFField(); } }
extern "C" { void CResGFFField_CResGFFField___1__S_CResGFFField(void* __instance, const CResGFFField& _0) { ::new (__instance) CResGFFField(_0); } }
CResGFFField& (CResGFFField::*_1140)(CResGFFField&&) = &CResGFFField::operator=;
extern "C" { void CResGFFFileHeader_CResGFFFileHeader(void* __instance) { ::new (__instance) CResGFFFileHeader(); } }
extern "C" { void CResGFFFileHeader_CResGFFFileHeader___1__S_CResGFFFileHeader(void* __instance, const CResGFFFileHeader& _0) { ::new (__instance) CResGFFFileHeader(_0); } }
CResGFFFileHeader& (CResGFFFileHeader::*_1141)(CResGFFFileHeader&&) = &CResGFFFileHeader::operator=;
extern "C" { void CResGFFLabel_CResGFFLabel(void* __instance) { ::new (__instance) CResGFFLabel(); } }
extern "C" { void CResGFFLabel_CResGFFLabel___1__S_CResGFFLabel(void* __instance, const CResGFFLabel& _0) { ::new (__instance) CResGFFLabel(_0); } }
CResGFFLabel& (CResGFFLabel::*_1142)(CResGFFLabel&&) = &CResGFFLabel::operator=;
extern "C" { void CResGFFStruct_CResGFFStruct(void* __instance) { ::new (__instance) CResGFFStruct(); } }
extern "C" { void CResGFFStruct_CResGFFStruct___1__S_CResGFFStruct(void* __instance, const CResGFFStruct& _0) { ::new (__instance) CResGFFStruct(_0); } }
CResGFFStruct& (CResGFFStruct::*_1143)(CResGFFStruct&&) = &CResGFFStruct::operator=;
extern "C" { void CResList_CResList(void* __instance) { ::new (__instance) CResList(); } }
extern "C" { void CResList_CResList___1__S_CResList(void* __instance, const CResList& _0) { ::new (__instance) CResList(_0); } }
CResList& (CResList::*_1144)(CResList&&) = &CResList::operator=;
extern "C" { void CResStructHeader_CResStructHeader(void* __instance) { ::new (__instance) CResStructHeader(); } }
extern "C" { void CResStructHeader_CResStructHeader___1__S_CResStructHeader(void* __instance, const CResStructHeader& _0) { ::new (__instance) CResStructHeader(_0); } }
CResStructHeader& (CResStructHeader::*_1145)(CResStructHeader&&) = &CResStructHeader::operator=;
extern "C" { void CResStruct_CResStruct(void* __instance) { ::new (__instance) CResStruct(); } }
extern "C" { void CResStruct_CResStruct___1__S_CResStruct(void* __instance, const CResStruct& _0) { ::new (__instance) CResStruct(_0); } }
CResStruct& (CResStruct::*_1146)(CResStruct&&) = &CResStruct::operator=;
extern "C" { void CResMDL_CResMDL___1__S_CResMDL(void* __instance, const CResMDL& _0) { ::new (__instance) CResMDL(_0); } }
CResMDL& (CResMDL::*_1147)(const CResMDL&) = &CResMDL::operator=;
extern "C" { void CResNCS_CResNCS___1__S_CResNCS(void* __instance, const CResNCS& _0) { ::new (__instance) CResNCS(_0); } }
CResNCS& (CResNCS::*_1148)(const CResNCS&) = &CResNCS::operator=;
extern "C" { void CResNDB_CResNDB___1__S_CResNDB(void* __instance, const CResNDB& _0) { ::new (__instance) CResNDB(_0); } }
CResNDB& (CResNDB::*_1149)(const CResNDB&) = &CResNDB::operator=;
extern "C" { void CResNSS_CResNSS___1__S_CResNSS(void* __instance, const CResNSS& _0) { ::new (__instance) CResNSS(_0); } }
CResNSS& (CResNSS::*_1150)(const CResNSS&) = &CResNSS::operator=;
extern "C" { void CResStructInternal_CResStructInternal_____S_CResStructInternal(void* __instance, CResStructInternal& _0) { ::new (__instance) CResStructInternal(_0); } }
CResStructInternal& (CResStructInternal::*_1151)(CResStructInternal&) = &CResStructInternal::operator=;
extern "C" { void CStringFieldIDType_CStringFieldIDType(void* __instance) { ::new (__instance) CStringFieldIDType(); } }
extern "C" { void CStringFieldIDType_CStringFieldIDType___1__S_CStringFieldIDType(void* __instance, const CStringFieldIDType& _0) { ::new (__instance) CStringFieldIDType(_0); } }
CStringFieldIDType& (CStringFieldIDType::*_1152)(CStringFieldIDType&&) = &CStringFieldIDType::operator=;
extern "C" { void CResStructLookUp_CResStructLookUp(void* __instance) { ::new (__instance) CResStructLookUp(); } }
extern "C" { void CResStructLookUp_CResStructLookUp___1__S_CResStructLookUp(void* __instance, const CResStructLookUp& _0) { ::new (__instance) CResStructLookUp(_0); } }
CResStructLookUp& (CResStructLookUp::*_1153)(CResStructLookUp&&) = &CResStructLookUp::operator=;
extern "C" { void CResTLK_CResTLK___1__S_CResTLK(void* __instance, const CResTLK& _0) { ::new (__instance) CResTLK(_0); } }
CResTLK& (CResTLK::*_1154)(const CResTLK&) = &CResTLK::operator=;
extern "C" { void CScriptCompiler_CScriptCompiler___1__S_CScriptCompiler(void* __instance, const CScriptCompiler& _0) { ::new (__instance) CScriptCompiler(_0); } }
CScriptCompiler& (CScriptCompiler::*_1155)(const CScriptCompiler&) = &CScriptCompiler::operator=;
extern "C" { void CScriptSourceFile_CScriptSourceFile___1__S_CScriptSourceFile(void* __instance, const CScriptSourceFile& _0) { ::new (__instance) CScriptSourceFile(_0); } }
CScriptSourceFile& (CScriptSourceFile::*_1156)(CScriptSourceFile&&) = &CScriptSourceFile::operator=;
extern "C" { void CScriptCompilerIncludeFileStackEntry_CScriptCompilerIncludeFileStackEntry___1__S_CScriptCompilerIncludeFileStackEntry(void* __instance, const CScriptCompilerIncludeFileStackEntry& _0) { ::new (__instance) CScriptCompilerIncludeFileStackEntry(_0); } }
CScriptCompilerIncludeFileStackEntry& (CScriptCompilerIncludeFileStackEntry::*_1157)(CScriptCompilerIncludeFileStackEntry&&) = &CScriptCompilerIncludeFileStackEntry::operator=;
extern "C" { void CScriptCompilerIncludeFileStackEntry__CScriptCompilerIncludeFileStackEntry(CScriptCompilerIncludeFileStackEntry* __instance) { delete __instance; } };
extern "C" { void CScriptCompilerIncludeFileStackEntry_CScriptCompilerIncludeFileStackEntry(void* __instance) { ::new (__instance) CScriptCompilerIncludeFileStackEntry(); } }
extern "C" { void CScriptCompilerIdentifierHashTableEntry_CScriptCompilerIdentifierHashTableEntry(void* __instance) { ::new (__instance) CScriptCompilerIdentifierHashTableEntry(); } }
extern "C" { void CScriptCompilerIdentifierHashTableEntry_CScriptCompilerIdentifierHashTableEntry___1__S_CScriptCompilerIdentifierHashTableEntry(void* __instance, const CScriptCompilerIdentifierHashTableEntry& _0) { ::new (__instance) CScriptCompilerIdentifierHashTableEntry(_0); } }
CScriptCompilerIdentifierHashTableEntry& (CScriptCompilerIdentifierHashTableEntry::*_1158)(CScriptCompilerIdentifierHashTableEntry&&) = &CScriptCompilerIdentifierHashTableEntry::operator=;
extern "C" { void CScriptCompilerIdListEntry_CScriptCompilerIdListEntry___1__S_CScriptCompilerIdListEntry(void* __instance, const CScriptCompilerIdListEntry& _0) { ::new (__instance) CScriptCompilerIdListEntry(_0); } }
CScriptCompilerIdListEntry& (CScriptCompilerIdListEntry::*_1159)(const CScriptCompilerIdListEntry&) = &CScriptCompilerIdListEntry::operator=;
extern "C" { void CScriptCompilerKeyWordEntry_CScriptCompilerKeyWordEntry___1__S_CScriptCompilerKeyWordEntry(void* __instance, const CScriptCompilerKeyWordEntry& _0) { ::new (__instance) CScriptCompilerKeyWordEntry(_0); } }
CScriptCompilerKeyWordEntry& (CScriptCompilerKeyWordEntry::*_1160)(CScriptCompilerKeyWordEntry&&) = &CScriptCompilerKeyWordEntry::operator=;
extern "C" { void CScriptCompilerKeyWordEntry__CScriptCompilerKeyWordEntry(CScriptCompilerKeyWordEntry* __instance) { delete __instance; } };
extern "C" { void CScriptCompilerKeyWordEntry_CScriptCompilerKeyWordEntry(void* __instance) { ::new (__instance) CScriptCompilerKeyWordEntry(); } }
extern "C" { void CScriptCompilerStackEntry_CScriptCompilerStackEntry(void* __instance) { ::new (__instance) CScriptCompilerStackEntry(); } }
extern "C" { void CScriptCompilerStackEntry_CScriptCompilerStackEntry___1__S_CScriptCompilerStackEntry(void* __instance, const CScriptCompilerStackEntry& _0) { ::new (__instance) CScriptCompilerStackEntry(_0); } }
CScriptCompilerStackEntry& (CScriptCompilerStackEntry::*_1161)(CScriptCompilerStackEntry&&) = &CScriptCompilerStackEntry::operator=;
extern "C" { void CScriptCompilerStructureEntry_CScriptCompilerStructureEntry___1__S_CScriptCompilerStructureEntry(void* __instance, const CScriptCompilerStructureEntry& _0) { ::new (__instance) CScriptCompilerStructureEntry(_0); } }
CScriptCompilerStructureEntry& (CScriptCompilerStructureEntry::*_1162)(CScriptCompilerStructureEntry&&) = &CScriptCompilerStructureEntry::operator=;
extern "C" { void CScriptCompilerStructureEntry__CScriptCompilerStructureEntry(CScriptCompilerStructureEntry* __instance) { delete __instance; } };
extern "C" { void CScriptCompilerStructureEntry_CScriptCompilerStructureEntry(void* __instance) { ::new (__instance) CScriptCompilerStructureEntry(); } }
extern "C" { void CScriptCompilerStructureFieldEntry_CScriptCompilerStructureFieldEntry___1__S_CScriptCompilerStructureFieldEntry(void* __instance, const CScriptCompilerStructureFieldEntry& _0) { ::new (__instance) CScriptCompilerStructureFieldEntry(_0); } }
CScriptCompilerStructureFieldEntry& (CScriptCompilerStructureFieldEntry::*_1163)(CScriptCompilerStructureFieldEntry&&) = &CScriptCompilerStructureFieldEntry::operator=;
extern "C" { void CScriptCompilerStructureFieldEntry__CScriptCompilerStructureFieldEntry(CScriptCompilerStructureFieldEntry* __instance) { delete __instance; } };
extern "C" { void CScriptCompilerStructureFieldEntry_CScriptCompilerStructureFieldEntry(void* __instance) { ::new (__instance) CScriptCompilerStructureFieldEntry(); } }
extern "C" { void CScriptCompilerSymbolTableEntry_CScriptCompilerSymbolTableEntry(void* __instance) { ::new (__instance) CScriptCompilerSymbolTableEntry(); } }
extern "C" { void CScriptCompilerSymbolTableEntry_CScriptCompilerSymbolTableEntry___1__S_CScriptCompilerSymbolTableEntry(void* __instance, const CScriptCompilerSymbolTableEntry& _0) { ::new (__instance) CScriptCompilerSymbolTableEntry(_0); } }
CScriptCompilerSymbolTableEntry& (CScriptCompilerSymbolTableEntry::*_1164)(CScriptCompilerSymbolTableEntry&&) = &CScriptCompilerSymbolTableEntry::operator=;
extern "C" { void CScriptCompilerVarStackEntry_CScriptCompilerVarStackEntry___1__S_CScriptCompilerVarStackEntry(void* __instance, const CScriptCompilerVarStackEntry& _0) { ::new (__instance) CScriptCompilerVarStackEntry(_0); } }
CScriptCompilerVarStackEntry& (CScriptCompilerVarStackEntry::*_1165)(CScriptCompilerVarStackEntry&&) = &CScriptCompilerVarStackEntry::operator=;
extern "C" { void CScriptCompilerVarStackEntry__CScriptCompilerVarStackEntry(CScriptCompilerVarStackEntry* __instance) { delete __instance; } };
extern "C" { void CScriptCompilerVarStackEntry_CScriptCompilerVarStackEntry(void* __instance) { ::new (__instance) CScriptCompilerVarStackEntry(); } }
extern "C" { void CScriptEvent_CScriptEvent___1__S_CScriptEvent(void* __instance, const CScriptEvent& _0) { ::new (__instance) CScriptEvent(_0); } }
CScriptEvent& (CScriptEvent::*_1166)(const CScriptEvent&) = &CScriptEvent::operator=;
extern "C" { void CScriptLog_CScriptLog___1__S_CScriptLog(void* __instance, const CScriptLog& _0) { ::new (__instance) CScriptLog(_0); } }
CScriptLog& (CScriptLog::*_1167)(CScriptLog&&) = &CScriptLog::operator=;
extern "C" { void CScriptLog__CScriptLog(CScriptLog* __instance) { delete __instance; } };
extern "C" { void CScriptLog_CScriptLog(void* __instance) { ::new (__instance) CScriptLog(); } }
extern "C" { void CScriptParseTreeNode_CScriptParseTreeNode(void* __instance) { ::new (__instance) CScriptParseTreeNode(); } }
extern "C" { void CScriptParseTreeNode_CScriptParseTreeNode___1__S_CScriptParseTreeNode(void* __instance, const CScriptParseTreeNode& _0) { ::new (__instance) CScriptParseTreeNode(_0); } }
CScriptParseTreeNode& (CScriptParseTreeNode::*_1168)(CScriptParseTreeNode&&) = &CScriptParseTreeNode::operator=;
extern "C" { void CScriptParseTreeNodeBlock_CScriptParseTreeNodeBlock(void* __instance) { ::new (__instance) CScriptParseTreeNodeBlock(); } }
extern "C" { void CScriptParseTreeNodeBlock_CScriptParseTreeNodeBlock___1__S_CScriptParseTreeNodeBlock(void* __instance, const CScriptParseTreeNodeBlock& _0) { ::new (__instance) CScriptParseTreeNodeBlock(_0); } }
CScriptParseTreeNodeBlock& (CScriptParseTreeNodeBlock::*_1169)(CScriptParseTreeNodeBlock&&) = &CScriptParseTreeNodeBlock::operator=;
extern "C" { void CScriptTalent_CScriptTalent___1__S_CScriptTalent(void* __instance, const CScriptTalent& _0) { ::new (__instance) CScriptTalent(_0); } }
CScriptTalent& (CScriptTalent::*_1170)(const CScriptTalent&) = &CScriptTalent::operator=;
extern "C" { void CServerAIBodyBagInfo_CServerAIBodyBagInfo(void* __instance) { ::new (__instance) CServerAIBodyBagInfo(); } }
extern "C" { void CServerAIBodyBagInfo_CServerAIBodyBagInfo___1__S_CServerAIBodyBagInfo(void* __instance, const CServerAIBodyBagInfo& _0) { ::new (__instance) CServerAIBodyBagInfo(_0); } }
CServerAIBodyBagInfo& (CServerAIBodyBagInfo::*_1171)(CServerAIBodyBagInfo&&) = &CServerAIBodyBagInfo::operator=;
extern "C" { void CServerAIEventNode_CServerAIEventNode(void* __instance) { ::new (__instance) CServerAIEventNode(); } }
extern "C" { void CServerAIEventNode_CServerAIEventNode___1__S_CServerAIEventNode(void* __instance, const CServerAIEventNode& _0) { ::new (__instance) CServerAIEventNode(_0); } }
CServerAIEventNode& (CServerAIEventNode::*_1172)(CServerAIEventNode&&) = &CServerAIEventNode::operator=;
extern "C" { void CServerAIList_CServerAIList___1__S_CServerAIList(void* __instance, const CServerAIList& _0) { ::new (__instance) CServerAIList(_0); } }
CServerAIList& (CServerAIList::*_1173)(const CServerAIList&) = &CServerAIList::operator=;
extern "C" { void CServerAIMaster_CServerAIMaster___1__S_CServerAIMaster(void* __instance, const CServerAIMaster& _0) { ::new (__instance) CServerAIMaster(_0); } }
CServerAIMaster& (CServerAIMaster::*_1174)(const CServerAIMaster&) = &CServerAIMaster::operator=;
CServerExoApp& (CServerExoApp::*_1175)(const CServerExoApp&) = &CServerExoApp::operator=;
extern "C" { void CServerExoApp_CServerExoApp___1__S_CServerExoApp(void* __instance, const CServerExoApp& _0) { ::new (__instance) CServerExoApp(_0); } }
extern "C" { void CServerExoAppInternal_CServerExoAppInternal___1__S_CServerExoAppInternal(void* __instance, const CServerExoAppInternal& _0) { ::new (__instance) CServerExoAppInternal(_0); } }
CServerExoAppInternal& (CServerExoAppInternal::*_1176)(const CServerExoAppInternal&) = &CServerExoAppInternal::operator=;
extern "C" { void CServerInfo_CServerInfo___1__S_CServerInfo(void* __instance, const CServerInfo& _0) { ::new (__instance) CServerInfo(_0); } }
CServerInfo& (CServerInfo::*_1177)(CServerInfo&&) = &CServerInfo::operator=;
extern "C" { void CServerInfo__CServerInfo(CServerInfo* __instance) { delete __instance; } };
extern "C" { void CServerNetOptions_CServerNetOptions___1__S_CServerNetOptions(void* __instance, const CServerNetOptions& _0) { ::new (__instance) CServerNetOptions(_0); } }
CServerNetOptions& (CServerNetOptions::*_1178)(CServerNetOptions&&) = &CServerNetOptions::operator=;
extern "C" { void CServerNetOptions__CServerNetOptions(CServerNetOptions* __instance) { delete __instance; } };
extern "C" { void CServerNetOptions_CServerNetOptions(void* __instance) { ::new (__instance) CServerNetOptions(); } }
extern "C" { void CServerOptionLookup_CServerOptionLookup___1__S_CServerOptionLookup(void* __instance, const CServerOptionLookup& _0) { ::new (__instance) CServerOptionLookup(_0); } }
CServerOptionLookup& (CServerOptionLookup::*_1179)(CServerOptionLookup&&) = &CServerOptionLookup::operator=;
extern "C" { void CServerOptionLookup_CServerOptionLookup(void* __instance) { ::new (__instance) CServerOptionLookup(); } }
extern "C" { void CSpell_Add_CSpell_Add(void* __instance) { ::new (__instance) CSpell_Add(); } }
extern "C" { void CSpell_Add_CSpell_Add___1__S_CSpell_Add(void* __instance, const CSpell_Add& _0) { ::new (__instance) CSpell_Add(_0); } }
CSpell_Add& (CSpell_Add::*_1180)(CSpell_Add&&) = &CSpell_Add::operator=;
extern "C" { void CSpell_Delete_CSpell_Delete(void* __instance) { ::new (__instance) CSpell_Delete(); } }
extern "C" { void CSpell_Delete_CSpell_Delete___1__S_CSpell_Delete(void* __instance, const CSpell_Delete& _0) { ::new (__instance) CSpell_Delete(_0); } }
CSpell_Delete& (CSpell_Delete::*_1181)(CSpell_Delete&&) = &CSpell_Delete::operator=;
extern "C" { void CStoreCustomer_CStoreCustomer___1__S_CStoreCustomer(void* __instance, const CStoreCustomer& _0) { ::new (__instance) CStoreCustomer(_0); } }
CStoreCustomer& (CStoreCustomer::*_1182)(CStoreCustomer&&) = &CStoreCustomer::operator=;
extern "C" { void CTlkFile_CTlkFile___1__S_CTlkFile(void* __instance, const CTlkFile& _0) { ::new (__instance) CTlkFile(_0); } }
CTlkFile& (CTlkFile::*_1183)(const CTlkFile&) = &CTlkFile::operator=;
extern "C" { void TLK_FILE_HEADER_TLK_FILE_HEADER___1__S_TLK_FILE_HEADER(void* __instance, const TLK_FILE_HEADER& _0) { ::new (__instance) TLK_FILE_HEADER(_0); } }
TLK_FILE_HEADER& (TLK_FILE_HEADER::*_1184)(TLK_FILE_HEADER&&) = &TLK_FILE_HEADER::operator=;
extern "C" { void TLK_FILE_HEADER_TLK_FILE_HEADER(void* __instance) { ::new (__instance) TLK_FILE_HEADER(); } }
extern "C" { void CTlkResFile_CTlkResFile___1__S_CTlkResFile(void* __instance, const CTlkResFile& _0) { ::new (__instance) CTlkResFile(_0); } }
CTlkResFile& (CTlkResFile::*_1185)(const CTlkResFile&) = &CTlkResFile::operator=;
extern "C" { void CTlkTable_CTlkTable___1__S_CTlkTable(void* __instance, const CTlkTable& _0) { ::new (__instance) CTlkTable(_0); } }
CTlkTable& (CTlkTable::*_1186)(const CTlkTable&) = &CTlkTable::operator=;
extern "C" { void CTlkTableToken_CTlkTableToken___1__S_CTlkTableToken(void* __instance, const CTlkTableToken& _0) { ::new (__instance) CTlkTableToken(_0); } }
CTlkTableToken& (CTlkTableToken::*_1187)(CTlkTableToken&&) = &CTlkTableToken::operator=;
extern "C" { void CTlkTableToken__CTlkTableToken(CTlkTableToken* __instance) { delete __instance; } };
extern "C" { void CTlkTableToken_CTlkTableToken(void* __instance) { ::new (__instance) CTlkTableToken(); } }
extern "C" { void CTlkTableTokenCustom_CTlkTableTokenCustom___1__S_CTlkTableTokenCustom(void* __instance, const CTlkTableTokenCustom& _0) { ::new (__instance) CTlkTableTokenCustom(_0); } }
CTlkTableTokenCustom& (CTlkTableTokenCustom::*_1188)(CTlkTableTokenCustom&&) = &CTlkTableTokenCustom::operator=;
extern "C" { void CTlkTableTokenCustom__CTlkTableTokenCustom(CTlkTableTokenCustom* __instance) { delete __instance; } };
extern "C" { void CTlkTableTokenCustom_CTlkTableTokenCustom(void* __instance) { ::new (__instance) CTlkTableTokenCustom(); } }
extern "C" { void CTwoDimArrays_CTwoDimArrays___1__S_CTwoDimArrays(void* __instance, const CTwoDimArrays& _0) { ::new (__instance) CTwoDimArrays(_0); } }
CTwoDimArrays& (CTwoDimArrays::*_1189)(const CTwoDimArrays&) = &CTwoDimArrays::operator=;
extern "C" { void CVirtualMachine_CVirtualMachine___1__S_CVirtualMachine(void* __instance, const CVirtualMachine& _0) { ::new (__instance) CVirtualMachine(_0); } }
CVirtualMachine& (CVirtualMachine::*_1190)(const CVirtualMachine&) = &CVirtualMachine::operator=;
extern "C" { void CVirtualMachineFile_CVirtualMachineFile___1__S_CVirtualMachineFile(void* __instance, const CVirtualMachineFile& _0) { ::new (__instance) CVirtualMachineFile(_0); } }
CVirtualMachineFile& (CVirtualMachineFile::*_1191)(const CVirtualMachineFile&) = &CVirtualMachineFile::operator=;
extern "C" { void CVirtualMachineScript_CVirtualMachineScript___1__S_CVirtualMachineScript(void* __instance, const CVirtualMachineScript& _0) { ::new (__instance) CVirtualMachineScript(_0); } }
CVirtualMachineScript& (CVirtualMachineScript::*_1192)(CVirtualMachineScript&&) = &CVirtualMachineScript::operator=;
extern "C" { void CVirtualMachineScript__CVirtualMachineScript(CVirtualMachineScript* __instance) { delete __instance; } };
extern "C" { void CVirtualMachineScript_CVirtualMachineScript(void* __instance) { ::new (__instance) CVirtualMachineScript(); } }
extern "C" { void CVirtualMachineStack_CVirtualMachineStack___1__S_CVirtualMachineStack(void* __instance, const CVirtualMachineStack& _0) { ::new (__instance) CVirtualMachineStack(_0); } }
CVirtualMachineStack& (CVirtualMachineStack::*_1193)(const CVirtualMachineStack&) = &CVirtualMachineStack::operator=;
extern "C" { void CVirtualMachineDebuggerInstance_CVirtualMachineDebuggerInstance___1__S_CVirtualMachineDebuggerInstance(void* __instance, const CVirtualMachineDebuggerInstance& _0) { ::new (__instance) CVirtualMachineDebuggerInstance(_0); } }
CVirtualMachineDebuggerInstance& (CVirtualMachineDebuggerInstance::*_1194)(const CVirtualMachineDebuggerInstance&) = &CVirtualMachineDebuggerInstance::operator=;
extern "C" { void CVirtualMachineDebugLoader_CVirtualMachineDebugLoader___1__S_CVirtualMachineDebugLoader(void* __instance, const CVirtualMachineDebugLoader& _0) { ::new (__instance) CVirtualMachineDebugLoader(_0); } }
CVirtualMachineDebugLoader& (CVirtualMachineDebugLoader::*_1195)(CVirtualMachineDebugLoader&&) = &CVirtualMachineDebugLoader::operator=;
extern "C" { void CVirtualMachineDebugLoader_CVirtualMachineDebugLoader(void* __instance) { ::new (__instance) CVirtualMachineDebugLoader(); } }
extern "C" { void CVirtualMachineDebuggingContext_CVirtualMachineDebuggingContext(void* __instance) { ::new (__instance) CVirtualMachineDebuggingContext(); } }
extern "C" { void CVirtualMachineDebuggingContext_CVirtualMachineDebuggingContext___1__S_CVirtualMachineDebuggingContext(void* __instance, const CVirtualMachineDebuggingContext& _0) { ::new (__instance) CVirtualMachineDebuggingContext(_0); } }
CVirtualMachineDebuggingContext& (CVirtualMachineDebuggingContext::*_1196)(CVirtualMachineDebuggingContext&&) = &CVirtualMachineDebuggingContext::operator=;
extern "C" { void CWalkHitInfo_CWalkHitInfo(void* __instance) { ::new (__instance) CWalkHitInfo(); } }
extern "C" { void CWalkHitInfo_CWalkHitInfo___1__S_CWalkHitInfo(void* __instance, const CWalkHitInfo& _0) { ::new (__instance) CWalkHitInfo(_0); } }
CWalkHitInfo& (CWalkHitInfo::*_1197)(CWalkHitInfo&&) = &CWalkHitInfo::operator=;
extern "C" { void CWorldTimer_CWorldTimer___1__S_CWorldTimer(void* __instance, const CWorldTimer& _0) { ::new (__instance) CWorldTimer(_0); } }
CWorldTimer& (CWorldTimer::*_1198)(const CWorldTimer&) = &CWorldTimer::operator=;
extern "C" { void ENCAPSULATED_HEADER_ENCAPSULATED_HEADER(void* __instance) { ::new (__instance) ENCAPSULATED_HEADER(); } }
extern "C" { void ENCAPSULATED_HEADER_ENCAPSULATED_HEADER___1__S_ENCAPSULATED_HEADER(void* __instance, const ENCAPSULATED_HEADER& _0) { ::new (__instance) ENCAPSULATED_HEADER(_0); } }
ENCAPSULATED_HEADER& (ENCAPSULATED_HEADER::*_1199)(ENCAPSULATED_HEADER&&) = &ENCAPSULATED_HEADER::operator=;
extern "C" { void ENCAPSULATED_RESLISTENTRY_ENCAPSULATED_RESLISTENTRY(void* __instance) { ::new (__instance) ENCAPSULATED_RESLISTENTRY(); } }
extern "C" { void ENCAPSULATED_RESLISTENTRY_ENCAPSULATED_RESLISTENTRY___1__S_ENCAPSULATED_RESLISTENTRY(void* __instance, const ENCAPSULATED_RESLISTENTRY& _0) { ::new (__instance) ENCAPSULATED_RESLISTENTRY(_0); } }
ENCAPSULATED_RESLISTENTRY& (ENCAPSULATED_RESLISTENTRY::*_1200)(ENCAPSULATED_RESLISTENTRY&&) = &ENCAPSULATED_RESLISTENTRY::operator=;
extern "C" { void ENCAPSULATED_RESLISTENTRY_E1_ENCAPSULATED_RESLISTENTRY_E1(void* __instance) { ::new (__instance) ENCAPSULATED_RESLISTENTRY_E1(); } }
extern "C" { void ENCAPSULATED_RESLISTENTRY_E1_ENCAPSULATED_RESLISTENTRY_E1___1__S_ENCAPSULATED_RESLISTENTRY_E1(void* __instance, const ENCAPSULATED_RESLISTENTRY_E1& _0) { ::new (__instance) ENCAPSULATED_RESLISTENTRY_E1(_0); } }
ENCAPSULATED_RESLISTENTRY_E1& (ENCAPSULATED_RESLISTENTRY_E1::*_1201)(ENCAPSULATED_RESLISTENTRY_E1&&) = &ENCAPSULATED_RESLISTENTRY_E1::operator=;
extern "C" { void EXO2DAHEADER_EXO2DAHEADER(void* __instance) { ::new (__instance) EXO2DAHEADER(); } }
extern "C" { void EXO2DAHEADER_EXO2DAHEADER___1__S_EXO2DAHEADER(void* __instance, const EXO2DAHEADER& _0) { ::new (__instance) EXO2DAHEADER(_0); } }
EXO2DAHEADER& (EXO2DAHEADER::*_1202)(EXO2DAHEADER&&) = &EXO2DAHEADER::operator=;
extern "C" { void EXOLTRHEADER_EXOLTRHEADER(void* __instance) { ::new (__instance) EXOLTRHEADER(); } }
extern "C" { void EXOLTRHEADER_EXOLTRHEADER___1__S_EXOLTRHEADER(void* __instance, const EXOLTRHEADER& _0) { ::new (__instance) EXOLTRHEADER(_0); } }
EXOLTRHEADER& (EXOLTRHEADER::*_1203)(EXOLTRHEADER&&) = &EXOLTRHEADER::operator=;
extern "C" { void IntendedConnectionData_IntendedConnectionData___1__S_IntendedConnectionData(void* __instance, const IntendedConnectionData& _0) { ::new (__instance) IntendedConnectionData(_0); } }
IntendedConnectionData& (IntendedConnectionData::*_1204)(IntendedConnectionData&&) = &IntendedConnectionData::operator=;
extern "C" { void IntendedConnectionData__IntendedConnectionData(IntendedConnectionData* __instance) { delete __instance; } };
extern "C" { void IntendedConnectionData_IntendedConnectionData(void* __instance) { ::new (__instance) IntendedConnectionData(); } }
extern "C" { void KeyFileData_KeyFileData(void* __instance) { ::new (__instance) KeyFileData(); } }
extern "C" { void KeyFileData_KeyFileData___1__S_KeyFileData(void* __instance, const KeyFileData& _0) { ::new (__instance) KeyFileData(_0); } }
KeyFileData& (KeyFileData::*_1205)(KeyFileData&&) = &KeyFileData::operator=;
extern "C" { void KEYFILE_KEYENTRY_KEYFILE_KEYENTRY(void* __instance) { ::new (__instance) KEYFILE_KEYENTRY(); } }
extern "C" { void KEYFILE_KEYENTRY_KEYFILE_KEYENTRY___1__S_KEYFILE_KEYENTRY(void* __instance, const KEYFILE_KEYENTRY& _0) { ::new (__instance) KEYFILE_KEYENTRY(_0); } }
KEYFILE_KEYENTRY& (KEYFILE_KEYENTRY::*_1206)(KEYFILE_KEYENTRY&&) = &KEYFILE_KEYENTRY::operator=;
extern "C" { void KEYFILE_RESFILENAME_KEYFILE_RESFILENAME(void* __instance) { ::new (__instance) KEYFILE_RESFILENAME(); } }
extern "C" { void KEYFILE_RESFILENAME_KEYFILE_RESFILENAME___1__S_KEYFILE_RESFILENAME(void* __instance, const KEYFILE_RESFILENAME& _0) { ::new (__instance) KEYFILE_RESFILENAME(_0); } }
KEYFILE_RESFILENAME& (KEYFILE_RESFILENAME::*_1207)(KEYFILE_RESFILENAME&&) = &KEYFILE_RESFILENAME::operator=;
extern "C" { void KXPacket_KXPacket(void* __instance) { ::new (__instance) KXPacket(); } }
extern "C" { void KXPacket_KXPacket___1__S_KXPacket(void* __instance, const KXPacket& _0) { ::new (__instance) KXPacket(_0); } }
KXPacket& (KXPacket::*_1208)(KXPacket&&) = &KXPacket::operator=;
extern "C" { void NWAREAHEADER_NWAREAHEADER(void* __instance) { ::new (__instance) NWAREAHEADER(); } }
extern "C" { void NWAREAHEADER_NWAREAHEADER___1__S_NWAREAHEADER(void* __instance, const NWAREAHEADER& _0) { ::new (__instance) NWAREAHEADER(_0); } }
NWAREAHEADER& (NWAREAHEADER::*_1209)(NWAREAHEADER&&) = &NWAREAHEADER::operator=;
NWMODULEENTRYINFO& (NWMODULEENTRYINFO::*_1210)(NWMODULEENTRYINFO&&) = &NWMODULEENTRYINFO::operator=;
extern "C" { void NWMODULEENTRYINFO_NWMODULEENTRYINFO(void* __instance) { ::new (__instance) NWMODULEENTRYINFO(); } }
extern "C" { void NWMODULEENTRYINFO_NWMODULEENTRYINFO___1__S_NWMODULEENTRYINFO(void* __instance, const NWMODULEENTRYINFO& _0) { ::new (__instance) NWMODULEENTRYINFO(_0); } }
extern "C" { void NWMODULEHEADER_NWMODULEHEADER(void* __instance) { ::new (__instance) NWMODULEHEADER(); } }
extern "C" { void NWMODULEHEADER_NWMODULEHEADER___1__S_NWMODULEHEADER(void* __instance, const NWMODULEHEADER& _0) { ::new (__instance) NWMODULEHEADER(_0); } }
NWMODULEHEADER& (NWMODULEHEADER::*_1211)(NWMODULEHEADER&&) = &NWMODULEHEADER::operator=;
extern "C" { void NWPlayerCharacterListClass_st_NWPlayerCharacterListClass_st(void* __instance) { ::new (__instance) NWPlayerCharacterListClass_st(); } }
extern "C" { void NWPlayerCharacterListClass_st_NWPlayerCharacterListClass_st___1__S_NWPlayerCharacterListClass_st(void* __instance, const NWPlayerCharacterListClass_st& _0) { ::new (__instance) NWPlayerCharacterListClass_st(_0); } }
NWPlayerCharacterListClass_st& (NWPlayerCharacterListClass_st::*_1212)(NWPlayerCharacterListClass_st&&) = &NWPlayerCharacterListClass_st::operator=;
extern "C" { void NWPlayerCharacterList_st_NWPlayerCharacterList_st___1__S_NWPlayerCharacterList_st(void* __instance, const NWPlayerCharacterList_st& _0) { ::new (__instance) NWPlayerCharacterList_st(_0); } }
NWPlayerCharacterList_st& (NWPlayerCharacterList_st::*_1213)(NWPlayerCharacterList_st&&) = &NWPlayerCharacterList_st::operator=;
extern "C" { void NWPlayerCharacterList_st__NWPlayerCharacterList_st(NWPlayerCharacterList_st* __instance) { delete __instance; } };
extern "C" { void NWPlayerCharacterList_st_NWPlayerCharacterList_st(void* __instance) { ::new (__instance) NWPlayerCharacterList_st(); } }
out_of_space_error& (out_of_space_error::*_1214)(out_of_space_error&&) = &out_of_space_error::operator=;
extern "C" { void PlatformIntrinsicsProvider_PlatformIntrinsicsProvider(void* __instance) { ::new (__instance) PlatformIntrinsicsProvider(); } }
extern "C" { void PlatformIntrinsicsProvider_PlatformIntrinsicsProvider___1__S_PlatformIntrinsicsProvider(void* __instance, const PlatformIntrinsicsProvider& _0) { ::new (__instance) PlatformIntrinsicsProvider(_0); } }
PlatformIntrinsicsProvider& (PlatformIntrinsicsProvider::*_1215)(PlatformIntrinsicsProvider&&) = &PlatformIntrinsicsProvider::operator=;
extern "C" { void Provider_Provider___1__S_Provider(void* __instance, const Provider& _0) { ::new (__instance) Provider(_0); } }
Provider& (Provider::*_1216)(Provider&&) = &Provider::operator=;
extern "C" { void Provider__Provider(Provider* __instance) { delete __instance; } };
extern "C" { void Provider_Provider(void* __instance) { ::new (__instance) Provider(); } }
extern "C" { void RES_FIXED_HEADER_RES_FIXED_HEADER(void* __instance) { ::new (__instance) RES_FIXED_HEADER(); } }
extern "C" { void RES_FIXED_HEADER_RES_FIXED_HEADER___1__S_RES_FIXED_HEADER(void* __instance, const RES_FIXED_HEADER& _0) { ::new (__instance) RES_FIXED_HEADER(_0); } }
RES_FIXED_HEADER& (RES_FIXED_HEADER::*_1217)(RES_FIXED_HEADER&&) = &RES_FIXED_HEADER::operator=;
extern "C" { void SETEntry_SETEntry___1__S_SETEntry(void* __instance, const SETEntry& _0) { ::new (__instance) SETEntry(_0); } }
SETEntry& (SETEntry::*_1218)(SETEntry&&) = &SETEntry::operator=;
extern "C" { void SETEntry__SETEntry(SETEntry* __instance) { delete __instance; } };
extern "C" { void SETEntry_SETEntry(void* __instance) { ::new (__instance) SETEntry(); } }
extern "C" { void SETSection_SETSection___1__S_SETSection(void* __instance, const SETSection& _0) { ::new (__instance) SETSection(_0); } }
SETSection& (SETSection::*_1219)(SETSection&&) = &SETSection::operator=;
extern "C" { void SETSection__SETSection(SETSection* __instance) { delete __instance; } };
extern "C" { void SETSection_SETSection(void* __instance) { ::new (__instance) SETSection(); } }
extern "C" { void SNWItemFlags_SNWItemFlags(void* __instance) { ::new (__instance) SNWItemFlags(); } }
extern "C" { void SNWItemFlags_SNWItemFlags___1__S_SNWItemFlags(void* __instance, const SNWItemFlags& _0) { ::new (__instance) SNWItemFlags(_0); } }
SNWItemFlags& (SNWItemFlags::*_1220)(SNWItemFlags&&) = &SNWItemFlags::operator=;
extern "C" { void SqlQueryEngineStructure_SqlQueryEngineStructure___1__S_SqlQueryEngineStructure(void* __instance, const SqlQueryEngineStructure& _0) { ::new (__instance) SqlQueryEngineStructure(_0); } }
SqlQueryEngineStructure& (SqlQueryEngineStructure::*_1221)(SqlQueryEngineStructure&&) = &SqlQueryEngineStructure::operator=;
extern "C" { void SqlQueryEngineStructure__SqlQueryEngineStructure(SqlQueryEngineStructure* __instance) { delete __instance; } };
extern "C" { void SSubNetProfile_SSubNetProfile___1__S_SSubNetProfile(void* __instance, const SSubNetProfile& _0) { ::new (__instance) SSubNetProfile(_0); } }
SSubNetProfile& (SSubNetProfile::*_1222)(SSubNetProfile&&) = &SSubNetProfile::operator=;
extern "C" { void SSubNetProfile__SSubNetProfile(SSubNetProfile* __instance) { delete __instance; } };
extern "C" { void SSubNetProfile_SSubNetProfile(void* __instance) { ::new (__instance) SSubNetProfile(); } }
extern "C" { void StackElement_StackElement(void* __instance) { ::new (__instance) StackElement(); } }
extern "C" { void StackElement_StackElement___1__S_StackElement(void* __instance, const StackElement& _0) { ::new (__instance) StackElement(_0); } }
StackElement& (StackElement::*_1223)(StackElement&&) = &StackElement::operator=;
extern "C" { void STR_RES_STR_RES___1__S_STR_RES(void* __instance, const STR_RES& _0) { ::new (__instance) STR_RES(_0); } }
STR_RES& (STR_RES::*_1224)(STR_RES&&) = &STR_RES::operator=;
extern "C" { void STR_RES__STR_RES(STR_RES* __instance) { delete __instance; } };
extern "C" { void STR_RES_STR_RES(void* __instance) { ::new (__instance) STR_RES(); } }
extern "C" { void STR_RES_HEADER_STR_RES_HEADER(void* __instance) { ::new (__instance) STR_RES_HEADER(); } }
extern "C" { void STR_RES_HEADER_STR_RES_HEADER___1__S_STR_RES_HEADER(void* __instance, const STR_RES_HEADER& _0) { ::new (__instance) STR_RES_HEADER(_0); } }
STR_RES_HEADER& (STR_RES_HEADER::*_1225)(STR_RES_HEADER&&) = &STR_RES_HEADER::operator=;
extern "C" { void STR_RES_HEADER_OLD_STR_RES_HEADER_OLD(void* __instance) { ::new (__instance) STR_RES_HEADER_OLD(); } }
extern "C" { void STR_RES_HEADER_OLD_STR_RES_HEADER_OLD___1__S_STR_RES_HEADER_OLD(void* __instance, const STR_RES_HEADER_OLD& _0) { ::new (__instance) STR_RES_HEADER_OLD(_0); } }
STR_RES_HEADER_OLD& (STR_RES_HEADER_OLD::*_1226)(STR_RES_HEADER_OLD&&) = &STR_RES_HEADER_OLD::operator=;
