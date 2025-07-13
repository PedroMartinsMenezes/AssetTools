namespace AssetTool
{
    [JsonAsset("ClothConfigNv")]
    public class UClothConfigNv : UClothConfigCommon
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}