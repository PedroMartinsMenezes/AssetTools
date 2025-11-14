namespace AssetTool
{
    [JsonAsset("GameplayTagsList")]
    public class UGameplayTagsList : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RestrictedGameplayTagsList")]
    public class URestrictedGameplayTagsList : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameplayTagsSettings")]
    public class UGameplayTagsSettings : UGameplayTagsList
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameplayTagsDeveloperSettings")]
    public class UGameplayTagsDeveloperSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}