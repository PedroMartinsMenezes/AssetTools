namespace AssetTool
{
    [JsonAsset("NavigationGraphNodeComponent")]
    public class UNavigationGraphNodeComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}