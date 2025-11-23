namespace AssetTool
{
    [JsonAsset("BaseMediaSource")]
    public class UBaseMediaSource : UObject
    {
        public Dictionary<FGuid, FGuid> DummyPlatformPlayers;
        public FString DummyDefaultPlayer;
        public Dictionary<FString, FName> OldPlatformPlayerNames;
        public Dictionary<FGuid, FGuid> PlatformGuidPlayers;

        [Location("void UBaseMediaSource::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!transfer.Supports.RenameMediaSourcePlatformPlayers)
            {
                if (!transfer.GlobalObjects.IsFilterEditorOnly())
                {
                    transfer.Move(ref DummyPlatformPlayers);
                }
                transfer.Move(ref DummyDefaultPlayer);
            }
            else
            {
                if (!transfer.Supports.SerializeGUIDsInMediaSourceInsteadOfPlainNames)
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