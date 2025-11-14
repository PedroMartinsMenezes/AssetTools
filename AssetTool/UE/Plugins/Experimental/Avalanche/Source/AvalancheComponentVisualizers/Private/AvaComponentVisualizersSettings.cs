namespace AssetTool
{
    [JsonAsset("AvaComponentVisualizersSettings")]
    public class UAvaComponentVisualizersSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}