// GENERATED AUTOMATICALLY FROM 'Assets/Script/Controller/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""id"": ""b4fe58d2-d73b-4ea5-ae3b-51d7675781a8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""02683b98-c112-480f-8549-a8fc03aaf85d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cf598ddf-7fa9-4fe6-88ad-5b09ee5d5114"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpRelease"",
                    ""type"": ""Button"",
                    ""id"": ""b21cc446-5f88-4503-9b23-21c070e8190f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwordSwing"",
                    ""type"": ""Button"",
                    ""id"": ""ff8c6cab-a322-43e8-b9ee-3dc02250c395"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Element Special 1"",
                    ""type"": ""Button"",
                    ""id"": ""ca9c08ef-2248-4f5f-9c5d-1348b304c40a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""a453bfd2-487c-47b7-b09c-86a94543fe7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Guard Release"",
                    ""type"": ""Button"",
                    ""id"": ""e38d4642-0ae6-4cf3-bb9d-3d59f45152f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9520fbd5-f796-4757-8642-98b3a507f0cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""fe94e74e-2574-4df0-89c4-0305ea0478d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""d5c9b8a4-dc50-4abf-b151-cdf5eebe687f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastFall"",
                    ""type"": ""Button"",
                    ""id"": ""c954365a-ce45-4872-9d19-1cde1d6edb41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Movement"",
                    ""id"": ""e7ae236d-cb9b-4487-9e27-6659da3476ab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4e2e5fd5-1017-401d-a2ed-37801c3510cc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e6992ed2-9292-4c71-bbde-b49bb2c871d1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""431820a0-37c8-4b77-9080-c565a080538d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwordSwing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3fdd414-0724-42a9-a6c3-324ada27c141"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element Special 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1dc6e02-8059-4a3f-9881-aed797533fd5"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40bc7c63-2552-4792-83a0-3216fe03c238"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9ed5be7-296f-46a9-b9da-8788cadb6975"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f2f4320-dbff-40a6-82aa-ea89a3460b98"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""654a7d94-5b12-4aa7-8cbc-667f5dcfe622"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c7e4c52-c213-4339-9e47-b4c0203a631e"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1440919-aa54-4dba-a2a4-68274f4f4c18"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de0b24c6-d3d6-41d4-82a6-7f199a813f9a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardLayout2"",
            ""id"": ""c47409d5-87b7-49e5-b6a9-bddc9ed31137"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""bbb5afb2-d7dd-412e-a723-d860d76fa9e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0e5debf7-3a40-438c-a4af-68f6371df4b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump Release"",
                    ""type"": ""Button"",
                    ""id"": ""23b3f825-604e-4841-86e0-02b063febdb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwordSwing"",
                    ""type"": ""Button"",
                    ""id"": ""166b08e2-964e-4bfa-bc04-168add1e580c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Element Special 1"",
                    ""type"": ""Button"",
                    ""id"": ""43822585-38fa-4995-827b-9fb69f6ac519"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""3f7420fd-0019-405a-b109-bda66893df34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard Release"",
                    ""type"": ""Button"",
                    ""id"": ""4bc0ac60-2172-472b-9192-17d137fec8ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""22ce2ba3-581f-41f7-bc1b-20b01799016c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""cbd95263-c10a-49ea-8d22-f8f0df0c6097"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""26ad3a1d-854e-4840-bf2a-fd8fbf684374"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6541a7ba-7655-49b1-9f9b-a06c6ab664f2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a9cb5d1d-996b-477d-83b8-3b0a091f5064"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""40286f35-ac63-4e81-a4af-4542b8519730"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b3213a6-bbd4-4f16-91f0-92d07e1670ea"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d717eb6-3eb0-4775-b1c3-307135c37ac9"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwordSwing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a1f9ec8-352d-4b46-8752-2e44c192f90d"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element Special 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a77afeaf-6dfb-4c6f-94da-5f6e86536a9d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b98259af-c79b-4642-afbc-78d9fe926981"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb515af9-403a-4df4-8058-ce70a1a398ff"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1fc0090-abe3-4061-acd0-7ef29b885580"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XBOX"",
            ""id"": ""be5e47c0-57fe-4a58-8497-9646f46bd3a6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""239e2f80-f503-4ee4-a9f9-66fef06b36f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7b40b742-70ea-4356-8198-2b8884428694"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwordSwing"",
                    ""type"": ""Button"",
                    ""id"": ""4f3b4f0b-0438-4ece-bfdf-f8f756f5ac21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Element Special 1"",
                    ""type"": ""Button"",
                    ""id"": ""0c03d2b8-c007-40dd-a3e5-9db4e7e033b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""214a03ef-9ca3-4469-8068-a1ef415012a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard Release"",
                    ""type"": ""Button"",
                    ""id"": ""a41f893c-2021-4d06-a3a8-cd6a4c2a1f77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""c27c59cc-2151-48d9-9ab1-2fa121d9499d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""88b1c53d-93e1-4a7e-afb4-89f85d447623"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""8ac82f9b-5d6a-410c-b1c2-49aefbc1e1b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastFall"",
                    ""type"": ""Button"",
                    ""id"": ""cf3e9d05-5b9f-4183-96b5-5e53736be7e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9f7f383f-4f9b-4129-aea0-ad9399d4e05d"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0382bee5-4116-41ed-ab02-86a4a696c3fc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""98694b70-9945-48d6-948c-a09ecb8625d2"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""79ea4a89-bd93-4936-b4d2-7e1c8e479aa5"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""effed0dc-d7f5-4250-8a87-9cc688489c37"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwordSwing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e343ef40-0f67-48ed-9c64-f0aa3e5be582"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element Special 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93d57159-b81e-450d-a038-aca2d9516f85"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e9df7e9-7e31-44e1-9c32-a15ae16a0e88"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c729b9a6-a44c-4173-bdac-5028c08d0afa"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a4c5404-b582-4f86-8bb4-fcda52d8e939"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""31889440-f4c2-4286-a377-9e08edd8e209"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1d9582b1-78d7-4be0-bf7a-23eca2d480d6"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8ed893e8-9878-41e2-9981-ef0800e970f8"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""43bfed3b-ee64-43db-af6f-93ef745c9e05"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c819e446-c976-4629-b7fb-a868418d0777"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e27d1b5c-d124-4f6a-962d-14ed2019b018"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PS4"",
            ""id"": ""512af26d-948a-4aa3-8cb9-a80c1d19a2c9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""b6f4346f-162b-4a61-b94d-d4b25e3e849a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9d01b67d-4216-48cd-97a8-d5b81e065256"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sword Swing"",
                    ""type"": ""Button"",
                    ""id"": ""7bd3abc5-2220-4f78-9aea-76c640ad1220"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Element Special 1"",
                    ""type"": ""Button"",
                    ""id"": ""3b1818a7-b225-413f-acbf-1daf77a96f3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""bbff89fb-c808-4860-9465-d54d775b18a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard Release"",
                    ""type"": ""Button"",
                    ""id"": ""ab93e9c2-82fb-494e-abbb-41023a5716ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""60ddeeda-0c03-4a38-9a21-09234cea6f9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""b94a50d8-a8e4-4639-855d-b683af846bb6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastFall"",
                    ""type"": ""Button"",
                    ""id"": ""43f80de7-7c6d-49d1-ade0-6e7b0a66dc0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f32505d6-6803-4016-8221-c99501da527d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""34666b4a-f91e-4e6f-9627-be771161b5b2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""60cd5c32-cffb-4000-a173-5dc055678404"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b437c5ef-c523-40be-838b-df3c31ae04e6"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cd9db592-b9c0-471e-8fbd-3da6869ca521"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3bf3690-f900-4d2d-b24d-7a70fb14fb3e"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element Special 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ed531df-46e8-45b4-abd7-17ce6f4581f5"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sword Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4253cc08-9c9c-4131-989d-ded338a0cc8a"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbcc10a8-c475-4fd7-a2e8-5c09a991b141"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a01ac0f8-50da-4898-9354-54fd858f922b"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b31b9c9b-ab9b-4500-b955-5d7bff8ac20f"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6401c924-982d-44f6-9ebf-7bb5063c6199"",
                    ""path"": ""<DualShockGamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3d14badc-2459-49e7-a48e-d59bb5e0dafa"",
                    ""path"": ""<DualShockGamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dcb84487-55d7-453d-b170-85ca87746c3e"",
                    ""path"": ""<DualShockGamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9cb3699f-9878-4a7e-aadf-079d3f2aa108"",
                    ""path"": ""<DualShockGamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""18438749-471e-4eec-aa8c-4a2bdf88c61d"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40f50f99-20bf-44c6-8bd0-be0e9f35be8e"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""id"": ""dff21eaf-0c5e-4f90-8011-012e1ddfdc21"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""2cd4f6ef-a157-475a-8edf-7bba3539a886"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d810a00f-7c0f-463f-b09f-30e673470a6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwordSwing"",
                    ""type"": ""Button"",
                    ""id"": ""0707f1e0-5fab-4aa1-b7d3-3254a588a2af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Element Special 1"",
                    ""type"": ""Button"",
                    ""id"": ""ad131e52-acc5-4fca-8f15-8acbfe01593c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""cb43414a-720f-4dec-a836-45bb2c53672b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard Release"",
                    ""type"": ""Button"",
                    ""id"": ""290a6869-33ef-4790-b84a-1ef5fa81c949"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""5c161d6e-ab51-42ad-9331-d7de4cd338d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""00087413-4f99-49fa-be60-a21c5c3da17a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastFall"",
                    ""type"": ""Button"",
                    ""id"": ""c65435df-0d43-49cd-87d4-309017013257"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7713d837-224c-4436-8058-bb3653663346"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8514586f-b8fe-40ea-a3de-dfe261e3cc47"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""598256fc-213b-42f9-aecb-c478657b58d1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eabfa8c0-4e8c-428e-b4f3-7bd013627a3a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""644429b0-2f4d-4132-97fb-ac6d79fe5743"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwordSwing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""175f2d7c-4ba8-401c-84b4-feba3bc6a2b3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element Special 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""baf4406a-d97c-4196-815d-01fa9865cb1a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1ec893f-042c-462b-a401-942558cf574c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df12cb16-a8c8-422a-bc8a-32ce5ffc198e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""66ba88ed-ea1a-4747-938f-56c161870070"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4b02ff9c-9b5b-4dd7-9d3c-150a00d50be5"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""803c31f0-35fd-4f34-b267-e9d4c8732d36"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""438127ab-4b6d-41c6-b624-53116c441fd1"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""76f484d7-74bf-4c74-8ff1-3f816cd28934"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ecf4b205-a5b8-4362-b6a6-92360f0797d0"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard&Mouse
        m_KeyboardMouse = asset.FindActionMap("Keyboard&Mouse", throwIfNotFound: true);
        m_KeyboardMouse_Move = m_KeyboardMouse.FindAction("Move", throwIfNotFound: true);
        m_KeyboardMouse_Jump = m_KeyboardMouse.FindAction("Jump", throwIfNotFound: true);
        m_KeyboardMouse_JumpRelease = m_KeyboardMouse.FindAction("JumpRelease", throwIfNotFound: true);
        m_KeyboardMouse_SwordSwing = m_KeyboardMouse.FindAction("SwordSwing", throwIfNotFound: true);
        m_KeyboardMouse_ElementSpecial1 = m_KeyboardMouse.FindAction("Element Special 1", throwIfNotFound: true);
        m_KeyboardMouse_Guard = m_KeyboardMouse.FindAction("Guard", throwIfNotFound: true);
        m_KeyboardMouse_GuardRelease = m_KeyboardMouse.FindAction("Guard Release", throwIfNotFound: true);
        m_KeyboardMouse_Pause = m_KeyboardMouse.FindAction("Pause", throwIfNotFound: true);
        m_KeyboardMouse_Dash = m_KeyboardMouse.FindAction("Dash", throwIfNotFound: true);
        m_KeyboardMouse_Aim = m_KeyboardMouse.FindAction("Aim", throwIfNotFound: true);
        m_KeyboardMouse_FastFall = m_KeyboardMouse.FindAction("FastFall", throwIfNotFound: true);
        // KeyboardLayout2
        m_KeyboardLayout2 = asset.FindActionMap("KeyboardLayout2", throwIfNotFound: true);
        m_KeyboardLayout2_Move = m_KeyboardLayout2.FindAction("Move", throwIfNotFound: true);
        m_KeyboardLayout2_Jump = m_KeyboardLayout2.FindAction("Jump", throwIfNotFound: true);
        m_KeyboardLayout2_JumpRelease = m_KeyboardLayout2.FindAction("Jump Release", throwIfNotFound: true);
        m_KeyboardLayout2_SwordSwing = m_KeyboardLayout2.FindAction("SwordSwing", throwIfNotFound: true);
        m_KeyboardLayout2_ElementSpecial1 = m_KeyboardLayout2.FindAction("Element Special 1", throwIfNotFound: true);
        m_KeyboardLayout2_Guard = m_KeyboardLayout2.FindAction("Guard", throwIfNotFound: true);
        m_KeyboardLayout2_GuardRelease = m_KeyboardLayout2.FindAction("Guard Release", throwIfNotFound: true);
        m_KeyboardLayout2_Pause = m_KeyboardLayout2.FindAction("Pause", throwIfNotFound: true);
        m_KeyboardLayout2_Dash = m_KeyboardLayout2.FindAction("Dash", throwIfNotFound: true);
        // XBOX
        m_XBOX = asset.FindActionMap("XBOX", throwIfNotFound: true);
        m_XBOX_Move = m_XBOX.FindAction("Move", throwIfNotFound: true);
        m_XBOX_Jump = m_XBOX.FindAction("Jump", throwIfNotFound: true);
        m_XBOX_SwordSwing = m_XBOX.FindAction("SwordSwing", throwIfNotFound: true);
        m_XBOX_ElementSpecial1 = m_XBOX.FindAction("Element Special 1", throwIfNotFound: true);
        m_XBOX_Guard = m_XBOX.FindAction("Guard", throwIfNotFound: true);
        m_XBOX_GuardRelease = m_XBOX.FindAction("Guard Release", throwIfNotFound: true);
        m_XBOX_Pause = m_XBOX.FindAction("Pause", throwIfNotFound: true);
        m_XBOX_Dash = m_XBOX.FindAction("Dash", throwIfNotFound: true);
        m_XBOX_Aim = m_XBOX.FindAction("Aim", throwIfNotFound: true);
        m_XBOX_FastFall = m_XBOX.FindAction("FastFall", throwIfNotFound: true);
        // PS4
        m_PS4 = asset.FindActionMap("PS4", throwIfNotFound: true);
        m_PS4_Move = m_PS4.FindAction("Move", throwIfNotFound: true);
        m_PS4_Jump = m_PS4.FindAction("Jump", throwIfNotFound: true);
        m_PS4_SwordSwing = m_PS4.FindAction("Sword Swing", throwIfNotFound: true);
        m_PS4_ElementSpecial1 = m_PS4.FindAction("Element Special 1", throwIfNotFound: true);
        m_PS4_Guard = m_PS4.FindAction("Guard", throwIfNotFound: true);
        m_PS4_GuardRelease = m_PS4.FindAction("Guard Release", throwIfNotFound: true);
        m_PS4_Dash = m_PS4.FindAction("Dash", throwIfNotFound: true);
        m_PS4_Aim = m_PS4.FindAction("Aim", throwIfNotFound: true);
        m_PS4_FastFall = m_PS4.FindAction("FastFall", throwIfNotFound: true);
        m_PS4_Pause = m_PS4.FindAction("Pause", throwIfNotFound: true);
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_Move = m_Gamepad.FindAction("Move", throwIfNotFound: true);
        m_Gamepad_Jump = m_Gamepad.FindAction("Jump", throwIfNotFound: true);
        m_Gamepad_SwordSwing = m_Gamepad.FindAction("SwordSwing", throwIfNotFound: true);
        m_Gamepad_ElementSpecial1 = m_Gamepad.FindAction("Element Special 1", throwIfNotFound: true);
        m_Gamepad_Guard = m_Gamepad.FindAction("Guard", throwIfNotFound: true);
        m_Gamepad_GuardRelease = m_Gamepad.FindAction("Guard Release", throwIfNotFound: true);
        m_Gamepad_Dash = m_Gamepad.FindAction("Dash", throwIfNotFound: true);
        m_Gamepad_Aim = m_Gamepad.FindAction("Aim", throwIfNotFound: true);
        m_Gamepad_FastFall = m_Gamepad.FindAction("FastFall", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Keyboard&Mouse
    private readonly InputActionMap m_KeyboardMouse;
    private IKeyboardMouseActions m_KeyboardMouseActionsCallbackInterface;
    private readonly InputAction m_KeyboardMouse_Move;
    private readonly InputAction m_KeyboardMouse_Jump;
    private readonly InputAction m_KeyboardMouse_JumpRelease;
    private readonly InputAction m_KeyboardMouse_SwordSwing;
    private readonly InputAction m_KeyboardMouse_ElementSpecial1;
    private readonly InputAction m_KeyboardMouse_Guard;
    private readonly InputAction m_KeyboardMouse_GuardRelease;
    private readonly InputAction m_KeyboardMouse_Pause;
    private readonly InputAction m_KeyboardMouse_Dash;
    private readonly InputAction m_KeyboardMouse_Aim;
    private readonly InputAction m_KeyboardMouse_FastFall;
    public struct KeyboardMouseActions
    {
        private @PlayerInput m_Wrapper;
        public KeyboardMouseActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KeyboardMouse_Move;
        public InputAction @Jump => m_Wrapper.m_KeyboardMouse_Jump;
        public InputAction @JumpRelease => m_Wrapper.m_KeyboardMouse_JumpRelease;
        public InputAction @SwordSwing => m_Wrapper.m_KeyboardMouse_SwordSwing;
        public InputAction @ElementSpecial1 => m_Wrapper.m_KeyboardMouse_ElementSpecial1;
        public InputAction @Guard => m_Wrapper.m_KeyboardMouse_Guard;
        public InputAction @GuardRelease => m_Wrapper.m_KeyboardMouse_GuardRelease;
        public InputAction @Pause => m_Wrapper.m_KeyboardMouse_Pause;
        public InputAction @Dash => m_Wrapper.m_KeyboardMouse_Dash;
        public InputAction @Aim => m_Wrapper.m_KeyboardMouse_Aim;
        public InputAction @FastFall => m_Wrapper.m_KeyboardMouse_FastFall;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJump;
                @JumpRelease.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJumpRelease;
                @JumpRelease.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJumpRelease;
                @JumpRelease.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJumpRelease;
                @SwordSwing.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnSwordSwing;
                @ElementSpecial1.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnElementSpecial1;
                @Guard.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnGuard;
                @GuardRelease.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnGuardRelease;
                @Pause.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPause;
                @Dash.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnDash;
                @Aim.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @FastFall.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFastFall;
                @FastFall.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFastFall;
                @FastFall.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFastFall;
            }
            m_Wrapper.m_KeyboardMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @JumpRelease.started += instance.OnJumpRelease;
                @JumpRelease.performed += instance.OnJumpRelease;
                @JumpRelease.canceled += instance.OnJumpRelease;
                @SwordSwing.started += instance.OnSwordSwing;
                @SwordSwing.performed += instance.OnSwordSwing;
                @SwordSwing.canceled += instance.OnSwordSwing;
                @ElementSpecial1.started += instance.OnElementSpecial1;
                @ElementSpecial1.performed += instance.OnElementSpecial1;
                @ElementSpecial1.canceled += instance.OnElementSpecial1;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @GuardRelease.started += instance.OnGuardRelease;
                @GuardRelease.performed += instance.OnGuardRelease;
                @GuardRelease.canceled += instance.OnGuardRelease;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @FastFall.started += instance.OnFastFall;
                @FastFall.performed += instance.OnFastFall;
                @FastFall.canceled += instance.OnFastFall;
            }
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);

    // KeyboardLayout2
    private readonly InputActionMap m_KeyboardLayout2;
    private IKeyboardLayout2Actions m_KeyboardLayout2ActionsCallbackInterface;
    private readonly InputAction m_KeyboardLayout2_Move;
    private readonly InputAction m_KeyboardLayout2_Jump;
    private readonly InputAction m_KeyboardLayout2_JumpRelease;
    private readonly InputAction m_KeyboardLayout2_SwordSwing;
    private readonly InputAction m_KeyboardLayout2_ElementSpecial1;
    private readonly InputAction m_KeyboardLayout2_Guard;
    private readonly InputAction m_KeyboardLayout2_GuardRelease;
    private readonly InputAction m_KeyboardLayout2_Pause;
    private readonly InputAction m_KeyboardLayout2_Dash;
    public struct KeyboardLayout2Actions
    {
        private @PlayerInput m_Wrapper;
        public KeyboardLayout2Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KeyboardLayout2_Move;
        public InputAction @Jump => m_Wrapper.m_KeyboardLayout2_Jump;
        public InputAction @JumpRelease => m_Wrapper.m_KeyboardLayout2_JumpRelease;
        public InputAction @SwordSwing => m_Wrapper.m_KeyboardLayout2_SwordSwing;
        public InputAction @ElementSpecial1 => m_Wrapper.m_KeyboardLayout2_ElementSpecial1;
        public InputAction @Guard => m_Wrapper.m_KeyboardLayout2_Guard;
        public InputAction @GuardRelease => m_Wrapper.m_KeyboardLayout2_GuardRelease;
        public InputAction @Pause => m_Wrapper.m_KeyboardLayout2_Pause;
        public InputAction @Dash => m_Wrapper.m_KeyboardLayout2_Dash;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardLayout2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardLayout2Actions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardLayout2Actions instance)
        {
            if (m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnJump;
                @JumpRelease.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnJumpRelease;
                @JumpRelease.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnJumpRelease;
                @JumpRelease.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnJumpRelease;
                @SwordSwing.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnSwordSwing;
                @ElementSpecial1.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnElementSpecial1;
                @Guard.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnGuard;
                @GuardRelease.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnGuardRelease;
                @Pause.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnPause;
                @Dash.started -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_KeyboardLayout2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @JumpRelease.started += instance.OnJumpRelease;
                @JumpRelease.performed += instance.OnJumpRelease;
                @JumpRelease.canceled += instance.OnJumpRelease;
                @SwordSwing.started += instance.OnSwordSwing;
                @SwordSwing.performed += instance.OnSwordSwing;
                @SwordSwing.canceled += instance.OnSwordSwing;
                @ElementSpecial1.started += instance.OnElementSpecial1;
                @ElementSpecial1.performed += instance.OnElementSpecial1;
                @ElementSpecial1.canceled += instance.OnElementSpecial1;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @GuardRelease.started += instance.OnGuardRelease;
                @GuardRelease.performed += instance.OnGuardRelease;
                @GuardRelease.canceled += instance.OnGuardRelease;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public KeyboardLayout2Actions @KeyboardLayout2 => new KeyboardLayout2Actions(this);

    // XBOX
    private readonly InputActionMap m_XBOX;
    private IXBOXActions m_XBOXActionsCallbackInterface;
    private readonly InputAction m_XBOX_Move;
    private readonly InputAction m_XBOX_Jump;
    private readonly InputAction m_XBOX_SwordSwing;
    private readonly InputAction m_XBOX_ElementSpecial1;
    private readonly InputAction m_XBOX_Guard;
    private readonly InputAction m_XBOX_GuardRelease;
    private readonly InputAction m_XBOX_Pause;
    private readonly InputAction m_XBOX_Dash;
    private readonly InputAction m_XBOX_Aim;
    private readonly InputAction m_XBOX_FastFall;
    public struct XBOXActions
    {
        private @PlayerInput m_Wrapper;
        public XBOXActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_XBOX_Move;
        public InputAction @Jump => m_Wrapper.m_XBOX_Jump;
        public InputAction @SwordSwing => m_Wrapper.m_XBOX_SwordSwing;
        public InputAction @ElementSpecial1 => m_Wrapper.m_XBOX_ElementSpecial1;
        public InputAction @Guard => m_Wrapper.m_XBOX_Guard;
        public InputAction @GuardRelease => m_Wrapper.m_XBOX_GuardRelease;
        public InputAction @Pause => m_Wrapper.m_XBOX_Pause;
        public InputAction @Dash => m_Wrapper.m_XBOX_Dash;
        public InputAction @Aim => m_Wrapper.m_XBOX_Aim;
        public InputAction @FastFall => m_Wrapper.m_XBOX_FastFall;
        public InputActionMap Get() { return m_Wrapper.m_XBOX; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XBOXActions set) { return set.Get(); }
        public void SetCallbacks(IXBOXActions instance)
        {
            if (m_Wrapper.m_XBOXActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnJump;
                @SwordSwing.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnSwordSwing;
                @ElementSpecial1.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnElementSpecial1;
                @Guard.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnGuard;
                @GuardRelease.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnGuardRelease;
                @Pause.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnPause;
                @Dash.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnDash;
                @Aim.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnAim;
                @FastFall.started -= m_Wrapper.m_XBOXActionsCallbackInterface.OnFastFall;
                @FastFall.performed -= m_Wrapper.m_XBOXActionsCallbackInterface.OnFastFall;
                @FastFall.canceled -= m_Wrapper.m_XBOXActionsCallbackInterface.OnFastFall;
            }
            m_Wrapper.m_XBOXActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SwordSwing.started += instance.OnSwordSwing;
                @SwordSwing.performed += instance.OnSwordSwing;
                @SwordSwing.canceled += instance.OnSwordSwing;
                @ElementSpecial1.started += instance.OnElementSpecial1;
                @ElementSpecial1.performed += instance.OnElementSpecial1;
                @ElementSpecial1.canceled += instance.OnElementSpecial1;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @GuardRelease.started += instance.OnGuardRelease;
                @GuardRelease.performed += instance.OnGuardRelease;
                @GuardRelease.canceled += instance.OnGuardRelease;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @FastFall.started += instance.OnFastFall;
                @FastFall.performed += instance.OnFastFall;
                @FastFall.canceled += instance.OnFastFall;
            }
        }
    }
    public XBOXActions @XBOX => new XBOXActions(this);

    // PS4
    private readonly InputActionMap m_PS4;
    private IPS4Actions m_PS4ActionsCallbackInterface;
    private readonly InputAction m_PS4_Move;
    private readonly InputAction m_PS4_Jump;
    private readonly InputAction m_PS4_SwordSwing;
    private readonly InputAction m_PS4_ElementSpecial1;
    private readonly InputAction m_PS4_Guard;
    private readonly InputAction m_PS4_GuardRelease;
    private readonly InputAction m_PS4_Dash;
    private readonly InputAction m_PS4_Aim;
    private readonly InputAction m_PS4_FastFall;
    private readonly InputAction m_PS4_Pause;
    public struct PS4Actions
    {
        private @PlayerInput m_Wrapper;
        public PS4Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PS4_Move;
        public InputAction @Jump => m_Wrapper.m_PS4_Jump;
        public InputAction @SwordSwing => m_Wrapper.m_PS4_SwordSwing;
        public InputAction @ElementSpecial1 => m_Wrapper.m_PS4_ElementSpecial1;
        public InputAction @Guard => m_Wrapper.m_PS4_Guard;
        public InputAction @GuardRelease => m_Wrapper.m_PS4_GuardRelease;
        public InputAction @Dash => m_Wrapper.m_PS4_Dash;
        public InputAction @Aim => m_Wrapper.m_PS4_Aim;
        public InputAction @FastFall => m_Wrapper.m_PS4_FastFall;
        public InputAction @Pause => m_Wrapper.m_PS4_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PS4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PS4Actions set) { return set.Get(); }
        public void SetCallbacks(IPS4Actions instance)
        {
            if (m_Wrapper.m_PS4ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnJump;
                @SwordSwing.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnSwordSwing;
                @ElementSpecial1.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnElementSpecial1;
                @Guard.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnGuard;
                @GuardRelease.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnGuardRelease;
                @Dash.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnDash;
                @Aim.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnAim;
                @FastFall.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnFastFall;
                @FastFall.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnFastFall;
                @FastFall.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnFastFall;
                @Pause.started -= m_Wrapper.m_PS4ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PS4ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PS4ActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PS4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SwordSwing.started += instance.OnSwordSwing;
                @SwordSwing.performed += instance.OnSwordSwing;
                @SwordSwing.canceled += instance.OnSwordSwing;
                @ElementSpecial1.started += instance.OnElementSpecial1;
                @ElementSpecial1.performed += instance.OnElementSpecial1;
                @ElementSpecial1.canceled += instance.OnElementSpecial1;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @GuardRelease.started += instance.OnGuardRelease;
                @GuardRelease.performed += instance.OnGuardRelease;
                @GuardRelease.canceled += instance.OnGuardRelease;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @FastFall.started += instance.OnFastFall;
                @FastFall.performed += instance.OnFastFall;
                @FastFall.canceled += instance.OnFastFall;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PS4Actions @PS4 => new PS4Actions(this);

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_Move;
    private readonly InputAction m_Gamepad_Jump;
    private readonly InputAction m_Gamepad_SwordSwing;
    private readonly InputAction m_Gamepad_ElementSpecial1;
    private readonly InputAction m_Gamepad_Guard;
    private readonly InputAction m_Gamepad_GuardRelease;
    private readonly InputAction m_Gamepad_Dash;
    private readonly InputAction m_Gamepad_Aim;
    private readonly InputAction m_Gamepad_FastFall;
    public struct GamepadActions
    {
        private @PlayerInput m_Wrapper;
        public GamepadActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gamepad_Move;
        public InputAction @Jump => m_Wrapper.m_Gamepad_Jump;
        public InputAction @SwordSwing => m_Wrapper.m_Gamepad_SwordSwing;
        public InputAction @ElementSpecial1 => m_Wrapper.m_Gamepad_ElementSpecial1;
        public InputAction @Guard => m_Wrapper.m_Gamepad_Guard;
        public InputAction @GuardRelease => m_Wrapper.m_Gamepad_GuardRelease;
        public InputAction @Dash => m_Wrapper.m_Gamepad_Dash;
        public InputAction @Aim => m_Wrapper.m_Gamepad_Aim;
        public InputAction @FastFall => m_Wrapper.m_Gamepad_FastFall;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJump;
                @SwordSwing.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnSwordSwing;
                @SwordSwing.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnSwordSwing;
                @ElementSpecial1.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnElementSpecial1;
                @ElementSpecial1.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnElementSpecial1;
                @Guard.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnGuard;
                @GuardRelease.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnGuardRelease;
                @GuardRelease.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnGuardRelease;
                @Dash.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDash;
                @Aim.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAim;
                @FastFall.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnFastFall;
                @FastFall.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnFastFall;
                @FastFall.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnFastFall;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SwordSwing.started += instance.OnSwordSwing;
                @SwordSwing.performed += instance.OnSwordSwing;
                @SwordSwing.canceled += instance.OnSwordSwing;
                @ElementSpecial1.started += instance.OnElementSpecial1;
                @ElementSpecial1.performed += instance.OnElementSpecial1;
                @ElementSpecial1.canceled += instance.OnElementSpecial1;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @GuardRelease.started += instance.OnGuardRelease;
                @GuardRelease.performed += instance.OnGuardRelease;
                @GuardRelease.canceled += instance.OnGuardRelease;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @FastFall.started += instance.OnFastFall;
                @FastFall.performed += instance.OnFastFall;
                @FastFall.canceled += instance.OnFastFall;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);
    public interface IKeyboardMouseActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnJumpRelease(InputAction.CallbackContext context);
        void OnSwordSwing(InputAction.CallbackContext context);
        void OnElementSpecial1(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnGuardRelease(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
    }
    public interface IKeyboardLayout2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnJumpRelease(InputAction.CallbackContext context);
        void OnSwordSwing(InputAction.CallbackContext context);
        void OnElementSpecial1(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnGuardRelease(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IXBOXActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSwordSwing(InputAction.CallbackContext context);
        void OnElementSpecial1(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnGuardRelease(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
    }
    public interface IPS4Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSwordSwing(InputAction.CallbackContext context);
        void OnElementSpecial1(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnGuardRelease(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IGamepadActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSwordSwing(InputAction.CallbackContext context);
        void OnElementSpecial1(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnGuardRelease(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
    }
}
