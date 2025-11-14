namespace AssetTool
{
    [JsonAsset("MovieSceneChannelOverrideContainer")]
    public class UMovieSceneChannelOverrideContainer : UMovieSceneSignedObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}