namespace AssetTool
{
    [Location("void UAnimGraphNode_AssetPlayerBase::Serialize(FArchive& Ar)")]
    public class UAnimGraphNode_AssetPlayerBase : UAnimGraphNode_Base
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            /*
            Super::Serialize(Ar);

			Ar.UsingCustomVersion(FUE5MainStreamObjectVersion::GUID);

			if(Ar.IsLoading() && Ar.CustomVer(FUE5MainStreamObjectVersion::GUID) < FUE5MainStreamObjectVersion::AnimSyncGroupsExplicitSyncMethod)
			{
				if(SyncGroup_DEPRECATED.GroupName != NAME_None)
				{
					SyncGroup_DEPRECATED.Method = EAnimSyncMethod::SyncGroup;
				}
			}

			if(Ar.IsLoading() && Ar.CustomVer(FUE5MainStreamObjectVersion::GUID) < FUE5MainStreamObjectVersion::AnimNodeConstantDataRefactorPhase0)
			{
				FStructProperty* NodeProperty = GetFNodeProperty();
				if(NodeProperty->Struct->IsChildOf(FAnimNode_AssetPlayerBase::StaticStruct()))
				{
					FAnimNode_AssetPlayerBase* Node = NodeProperty->ContainerPtrToValuePtr<FAnimNode_AssetPlayerBase>(this);
					Node->SetGroupName(SyncGroup_DEPRECATED.GroupName);
					Node->SetGroupRole(SyncGroup_DEPRECATED.GroupRole);
					Node->SetGroupMethod(SyncGroup_DEPRECATED.Method);
				}
			}
			*/
            return this;
        }
    }
}