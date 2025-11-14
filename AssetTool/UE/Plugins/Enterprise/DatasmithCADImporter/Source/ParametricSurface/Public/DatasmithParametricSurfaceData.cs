namespace AssetTool
{
    [JsonAsset("DatasmithParametricSurfaceData")]
    public class UDatasmithParametricSurfaceData : UDatasmithAdditionalData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}