namespace AssetTool
{
    [JsonAsset("MovieSceneBindingPropertyInfoList")]
    public class UMovieSceneBindingPropertyInfoList : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSequenceEditorSubsystem")]
    public class ULevelSequenceEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}