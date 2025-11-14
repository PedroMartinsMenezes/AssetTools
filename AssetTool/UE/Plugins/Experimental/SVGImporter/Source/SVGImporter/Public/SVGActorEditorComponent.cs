namespace AssetTool
{
    [JsonAsset("SVGActorEditorComponent")]
    public class USVGActorEditorComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}