namespace AssetTool
{
    [JsonAsset("CharacterTrajectoryComponent")]
    public class UCharacterTrajectoryComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}