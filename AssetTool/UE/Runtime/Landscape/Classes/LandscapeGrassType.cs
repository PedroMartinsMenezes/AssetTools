namespace AssetTool
{
    [JsonAsset("LandscapeGrassType")]
    public class ULandscapeGrassType : UObject, ITransferible
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        ITransferible ITransferible.Move2(Transfer transfer)
        {
            return (ITransferible)base.Move(transfer);
        }
    }
}