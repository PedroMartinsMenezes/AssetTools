namespace AssetTool
{
    [TransferableStruct("WorldConditionQueryDefinition")]
    public class FWorldConditionQueryDefinition : ITransferable
    {
        public UScriptStruct StaticStruct;
        public FBool bHasSharedDefinition;

        [Location("bool FWorldConditionQueryDefinition::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
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