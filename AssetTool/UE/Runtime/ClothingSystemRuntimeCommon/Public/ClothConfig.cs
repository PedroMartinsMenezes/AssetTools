namespace AssetTool
{
    [JsonAsset("ClothConfigCommon")]
    public class UClothConfigCommon : UClothConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClothSharedConfigCommon")]
    public class UClothSharedConfigCommon : UClothConfigCommon
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}