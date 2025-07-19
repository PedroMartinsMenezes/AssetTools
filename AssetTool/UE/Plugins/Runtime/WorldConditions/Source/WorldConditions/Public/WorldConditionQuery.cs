namespace AssetTool
{
    [TransferibleStruct("WorldConditionQueryDefinition")]
    public class FWorldConditionQueryDefinition : ITransferible
    {
        public UScriptStruct StaticStruct;
        public FBool bHasSharedDefinition;

        [Location("bool FWorldConditionQueryDefinition::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            StaticStruct ??= new();
            StaticStruct.SerializeTaggedProperties(transfer);

            if (transfer.Supports.StructSharedDefinition)
            {
                transfer.Move(ref bHasSharedDefinition);
            }

            return this;
        }
    }
}