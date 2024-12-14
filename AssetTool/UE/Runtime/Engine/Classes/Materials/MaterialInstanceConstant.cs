namespace AssetTool
{
    [JsonAsset("MaterialInstanceConstant")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}