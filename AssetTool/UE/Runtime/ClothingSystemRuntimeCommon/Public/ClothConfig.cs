namespace AssetTool
{
    [JsonAsset("ClothConfigCommon")]
    public class UClothConfigCommon : UClothConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClothSharedConfigCommon")]
    public class UClothSharedConfigCommon : UClothConfigCommon
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}