namespace AssetTool
{
    [JsonAsset("PropertyPathTestObject")]
    public class UPropertyPathTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}