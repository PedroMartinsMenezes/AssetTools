namespace AssetTool
{
    [JsonAsset("ContextualAnimSceneActorComponent")]
    public class UContextualAnimSceneActorComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}