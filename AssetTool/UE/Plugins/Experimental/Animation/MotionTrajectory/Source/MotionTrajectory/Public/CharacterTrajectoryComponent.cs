namespace AssetTool
{
    [JsonAsset("CharacterTrajectoryComponent")]
    public class UCharacterTrajectoryComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}