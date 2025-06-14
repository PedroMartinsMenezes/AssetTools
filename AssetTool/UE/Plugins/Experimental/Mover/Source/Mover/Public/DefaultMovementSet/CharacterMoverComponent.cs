namespace AssetTool
{
    [JsonAsset("CharacterMoverComponent")]
    public class UCharacterMoverComponent : UMoverComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}