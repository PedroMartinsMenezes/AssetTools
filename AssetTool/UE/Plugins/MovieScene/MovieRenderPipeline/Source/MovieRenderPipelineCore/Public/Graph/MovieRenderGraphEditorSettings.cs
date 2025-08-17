namespace AssetTool
{
    [JsonAsset("MovieRenderGraphEditorSettings")]
    public class UMovieRenderGraphEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}