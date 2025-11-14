namespace AssetTool
{
    [JsonAsset("ClothConfigNv")]
    public class UClothConfigNv : UClothConfigCommon
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}