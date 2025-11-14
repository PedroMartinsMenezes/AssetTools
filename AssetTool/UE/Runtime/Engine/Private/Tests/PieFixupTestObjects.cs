namespace AssetTool
{
    [JsonAsset("PieFixupTestObject")]
    public class UPieFixupTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}