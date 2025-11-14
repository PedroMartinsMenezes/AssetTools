namespace AssetTool
{
    [JsonAsset("ContextualAnimSceneActorComponent")]
    public class UContextualAnimSceneActorComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}