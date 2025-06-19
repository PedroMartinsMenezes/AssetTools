namespace AssetTool
{
    [JsonAsset("MoverComponent", "KinematicMoverComponent")]
    public class UMoverComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}