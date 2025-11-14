namespace AssetTool
{
    [JsonAsset("CharacterMoverComponent")]
    public class UCharacterMoverComponent : UMoverComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}