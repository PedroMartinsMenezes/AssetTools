namespace AssetTool
{
    [JsonAsset("LyraContextEffectsLibraryFactory")]
    public class ULyraContextEffectsLibraryFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}