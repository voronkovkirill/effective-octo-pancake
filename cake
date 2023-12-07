  case .preview:
            newState.collage = elementsTransformer.translate(
                gestureState,
                in: state.collage
            )
            
        case .edit:
            newState.collage = shapesTranslator.translate(
                gestureState,
                in: newState.collage
            )
        }
        
        return newState
    }
    
