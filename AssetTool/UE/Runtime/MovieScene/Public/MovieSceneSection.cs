namespace AssetTool
{
    [JsonAsset("MovieSceneSection")]
    public class UMovieSceneSection : UMovieSceneSignedObject
    {
        [Location("void UMovieSceneSection::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}