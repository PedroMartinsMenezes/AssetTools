namespace AssetTool
{
    [JsonAsset("AvaComponentVisualizersSettings")]
    public class UAvaComponentVisualizersSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}