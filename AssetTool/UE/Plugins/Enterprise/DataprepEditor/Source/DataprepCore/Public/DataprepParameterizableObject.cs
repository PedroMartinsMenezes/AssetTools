namespace AssetTool
{
    [JsonAsset("DataprepParameterizableObject")]
    public class UDataprepParameterizableObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}