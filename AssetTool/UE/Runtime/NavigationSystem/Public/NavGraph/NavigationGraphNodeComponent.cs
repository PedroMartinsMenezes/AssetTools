namespace AssetTool
{
    [JsonAsset("NavigationGraphNodeComponent")]
    public class UNavigationGraphNodeComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}