namespace AssetTool
{
    [JsonAsset("MovieSceneChannelOverrideContainer")]
    public class UMovieSceneChannelOverrideContainer : UMovieSceneSignedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}