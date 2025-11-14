namespace AssetTool
{
    [JsonAsset("EditMeshPolygonsToolBuilder")]
    public class UEditMeshPolygonsToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditCommonProperties")]
    public class UPolyEditCommonProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsActionModeToolBuilder")]
    public class UEditMeshPolygonsActionModeToolBuilder : UEditMeshPolygonsToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsSelectionModeToolBuilder")]
    public class UEditMeshPolygonsSelectionModeToolBuilder : UEditMeshPolygonsToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsToolActionPropertySet")]
    public class UEditMeshPolygonsToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditTopologyProperties")]
    public class UPolyEditTopologyProperties : UEditMeshPolygonsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsToolActions")]
    public class UEditMeshPolygonsToolActions : UEditMeshPolygonsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsToolActions_Triangles")]
    public class UEditMeshPolygonsToolActions_Triangles : UEditMeshPolygonsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsToolUVActions")]
    public class UEditMeshPolygonsToolUVActions : UEditMeshPolygonsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsToolEdgeActions")]
    public class UEditMeshPolygonsToolEdgeActions : UEditMeshPolygonsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsToolEdgeActions_Triangles")]
    public class UEditMeshPolygonsToolEdgeActions_Triangles : UEditMeshPolygonsToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshPolygonsTool")]
    public class UEditMeshPolygonsTool : USingleTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}