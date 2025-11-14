namespace AssetTool
{
    [JsonAsset("MovieRenderGraphEditorSettings")]
    public class UMovieRenderGraphEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}