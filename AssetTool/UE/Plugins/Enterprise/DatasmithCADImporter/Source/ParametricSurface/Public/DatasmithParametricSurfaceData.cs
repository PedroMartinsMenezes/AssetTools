namespace AssetTool
{
    [JsonAsset("DatasmithParametricSurfaceData")]
    public class UDatasmithParametricSurfaceData : UDatasmithAdditionalData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}