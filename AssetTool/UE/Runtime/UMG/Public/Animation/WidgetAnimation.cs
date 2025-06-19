namespace AssetTool
{
    [JsonAsset("WidgetAnimation")]
    public class UWidgetAnimation : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}