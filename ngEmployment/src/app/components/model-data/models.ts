
export class Employment{
    employmentId: number;
    fullName: string;
    phone: string;
    email: string;
    startDate: Date;
    positionId: number;
    companyId: number;
}

export class ServiceEquipment {
    serviceEquipmentId: number;
    name: string;
}

export class Position {
    positionId: number;
    name: string;
}

export class Company {
    companyId: number;
    name: string;
}

export class AccessLevel {
    AccessLevelId: number;
    name: string;
}