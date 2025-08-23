namespace AssetTool
{
    [JsonAsset("ClothConfigBase")]
    public class UClothConfigBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClothSharedSimConfigBase")]
    public class UDEPRECATED_ClothSharedSimConfigBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}