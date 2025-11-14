namespace AssetTool
{
    [JsonAsset("ISMPoolComponent")]
    public class UISMPoolComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}