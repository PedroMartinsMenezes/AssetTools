namespace AssetTool
{
    [TransferibleStruct("GameplayTagContainer")]
    public class FGameplayTagContainer : ITransferible
    {
        public List<FName> Tags_DEPRECATED;
        public List<FGameplayTag> GameplayTags;

        [Location("bool FGameplayTagContainer::Serialize(FStructuredArchive::FSlot Slot)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_GAMEPLAY_TAG_CONTAINER_TAG_TYPE_CHANGE)
            {
                transfer.Move(ref Tags_DEPRECATED);
            }
            else
            {
                transfer.Move(ref GameplayTags);
            }
            return this;
        }
    }

    public class FGameplayTag : ITransferible
    {
        public FName TagName;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref TagName);
            return this;
        }
    }
}