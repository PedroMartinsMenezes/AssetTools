namespace AssetTool
{
    [JsonAsset("ActorActionUtility")]
    public class UActorActionUtility : UEditorUtilityObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}