namespace AssetTool
{
    [JsonAsset("DataprepOperation")]
    public class UDataprepOperation : UDataprepParameterizableObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepEditingOperation")]
    public class UDataprepEditingOperation : UDataprepOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}