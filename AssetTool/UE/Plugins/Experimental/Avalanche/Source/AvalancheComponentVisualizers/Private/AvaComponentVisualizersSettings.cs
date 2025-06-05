namespace AssetTool
{
    [JsonAsset("AvaComponentVisualizersSettings")]
    public class UAvaComponentVisualizersSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}