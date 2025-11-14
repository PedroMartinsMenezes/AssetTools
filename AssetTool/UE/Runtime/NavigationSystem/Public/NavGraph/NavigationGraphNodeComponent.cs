namespace AssetTool
{
    [JsonAsset("NavigationGraphNodeComponent")]
    public class UNavigationGraphNodeComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}