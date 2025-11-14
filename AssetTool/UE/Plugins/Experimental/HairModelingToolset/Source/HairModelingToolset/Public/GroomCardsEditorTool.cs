namespace AssetTool
{
    [JsonAsset("GroomCardsEditorToolBuilder")]
    public class UGroomCardsEditorToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditGroomCardsToolActionPropertySet")]
    public class UEditGroomCardsToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SelectGroomCardsToolActions")]
    public class USelectGroomCardsToolActions : UEditGroomCardsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditGroomCardsToolActions")]
    public class UEditGroomCardsToolActions : UEditGroomCardsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomCardsInfoToolProperties")]
    public class UGroomCardsInfoToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomCardsEditorTool")]
    public class UGroomCardsEditorTool : UMeshSurfacePointTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}