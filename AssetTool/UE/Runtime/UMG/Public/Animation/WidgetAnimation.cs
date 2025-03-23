namespace AssetTool
{
    [JsonAsset("WidgetAnimation")]
    public class UWidgetAnimation : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}