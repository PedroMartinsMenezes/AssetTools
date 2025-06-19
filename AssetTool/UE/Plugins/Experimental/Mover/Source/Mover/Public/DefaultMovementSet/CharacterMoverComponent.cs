namespace AssetTool
{
    [JsonAsset("CharacterMoverComponent")]
    public class UCharacterMoverComponent : UMoverComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}