namespace AssetTool
{
    [JsonAsset("MaterialInstanceConstant")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}