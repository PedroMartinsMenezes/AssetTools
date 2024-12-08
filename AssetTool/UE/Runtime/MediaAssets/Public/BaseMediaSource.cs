namespace AssetTool
{
    [JsonAsset("BaseMediaSource")]
    public class UBaseMediaSource : UMediaSource
    {
        public Dictionary<FGuid, FGuid> DummyPlatformPlayers;
        public FString DummyDefaultPlayer;
        public Dictionary<FString, FName> OldPlatformPlayerNames;
        public Dictionary<FGuid, FGuid> PlatformGuidPlayers;

        [Location("void UBaseMediaSource::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!Supports.RenameMediaSourcePlatformPlayers)
            {
                if (!GlobalObjects.IsFilterEditorOnly())
                {
                    transfer.Move(ref DummyPlatformPlayers);
                }
                transfer.Move(ref DummyDefaultPlayer);
            }
            else
            {
                if (!Supports.SerializeGUIDsInMediaSourceInsteadOfPlainNames)
                {
                    transfer.Move(ref OldPlatformPlayerNames);
                }
                else
                {
                    transfer.Move(ref PlatformGuidPlayers);
                }
            }

            return this;
        }
    }
}