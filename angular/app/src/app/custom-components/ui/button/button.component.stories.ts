import { Meta, moduleMetadata, Story } from "@storybook/angular";
import { CustomComponentsModule } from "../../custom-components.module";
import { ButtonComponent } from "./button.component";

export default {
    title: 'Button',
    component: ButtonComponent,
    decorators:[
        moduleMetadata({
            imports: [CustomComponentsModule]
        })
    ]
} as Meta<ButtonComponent>;

const Template: Story<ButtonComponent> = (args) => ({
    props: args
});

export const BasicButton = Template.bind({});
BasicButton.args = {
    buttonType: 'stroked',
    label: 'Test'
}

export const ButtonWithIcon = Template.bind({});
ButtonWithIcon.args = {
    buttonType: 'raised',
    label: 'Inicio',
    icon: 'home'
}
