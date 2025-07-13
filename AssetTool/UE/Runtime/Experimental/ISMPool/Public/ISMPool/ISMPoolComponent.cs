namespace AssetTool
{
    [JsonAsset("ISMPoolComponent")]
    public class UISMPoolComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}