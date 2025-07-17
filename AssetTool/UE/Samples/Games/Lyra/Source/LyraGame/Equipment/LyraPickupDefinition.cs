namespace AssetTool
{
    [JsonAsset("LyraPickupDefinition")]
    public class ULyraPickupDefinition : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraWeaponPickupDefinition")]
    public class ULyraWeaponPickupDefinition : ULyraPickupDefinition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}