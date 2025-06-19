namespace AssetTool
{
    [JsonAsset("RadialForceComponent")]
    public class URadialForceComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}