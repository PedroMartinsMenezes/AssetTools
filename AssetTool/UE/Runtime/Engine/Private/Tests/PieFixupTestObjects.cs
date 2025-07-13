namespace AssetTool
{
    [JsonAsset("PieFixupTestObject")]
    public class UPieFixupTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}