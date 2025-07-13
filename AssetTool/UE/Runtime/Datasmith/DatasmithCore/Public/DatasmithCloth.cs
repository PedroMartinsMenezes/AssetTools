namespace AssetTool
{
    [JsonAsset("DatasmithClothAssetFactory")]
    public class UDatasmithClothAssetFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithClothComponentFactory")]
    public class UDatasmithClothComponentFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}