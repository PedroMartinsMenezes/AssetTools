namespace AssetTool
{
    [JsonAsset("MoverComponent", "KinematicMoverComponent")]
    public class UMoverComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}