namespace AssetTool
{
    [JsonAsset("GroomCardsEditorToolBuilder")]
    public class UGroomCardsEditorToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditGroomCardsToolActionPropertySet")]
    public class UEditGroomCardsToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SelectGroomCardsToolActions")]
    public class USelectGroomCardsToolActions : UEditGroomCardsToolActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditGroomCardsToolActions")]
    public class UEditGroomCardsToolActions : UEditGroomCardsToolActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomCardsInfoToolProperties")]
    public class UGroomCardsInfoToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomCardsEditorTool")]
    public class UGroomCardsEditorTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}